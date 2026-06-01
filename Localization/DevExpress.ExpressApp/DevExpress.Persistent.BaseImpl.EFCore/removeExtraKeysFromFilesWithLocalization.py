import os
import xml.etree.ElementTree as ET

# Directory containing all .resx files
DIRECTORY = "."

MAIN_FILE = os.path.join(DIRECTORY, "ModuleLocalizationResources.resx")

# Parse main resx file
tree_main = ET.parse(MAIN_FILE)
root_main = tree_main.getroot()

# Collect all keys from the main file
main_keys = {data.get("name") for data in root_main.findall("data") if data.get("name")}

print(f"✅ Loaded {len(main_keys)} keys from {MAIN_FILE}")

# Process all localized resx files
for filename in os.listdir(DIRECTORY):
    if filename.startswith("ModuleLocalizationResources.") and filename.endswith(".resx") and filename != "ModuleLocalizationResources.resx":
        filepath = os.path.join(DIRECTORY, filename)
        print(f"\nProcessing {filename}...")

        tree = ET.parse(filepath)
        root = tree.getroot()

        removed_count = 0
        total_keys = 0

        # Collect <data> elements to remove (can't modify while iterating)
        to_remove = []
        for data in root.findall("data"):
            key = data.get("name")
            if not key:
                continue
            total_keys += 1
            if key not in main_keys:
                to_remove.append(data)

        # Remove the extra keys
        for data in to_remove:
            root.remove(data)
            removed_count += 1

        # Save updated file
        if removed_count > 0:
            tree.write(filepath, encoding="utf-8", xml_declaration=True)
            print(f"🧹 Removed {removed_count} / {total_keys} keys not found in base file.")
        else:
            print(f"✔ No extraneous keys found. ({total_keys} keys total)")