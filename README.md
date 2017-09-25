WARNING: This will affect your HomeMenu, it's a critical core of the 3DS. Be sure to have a HardMod/NTRBoot, or A9LH/Boot9Strap NAND backup ready to recover a **BRICK** (I used it once, I got a brick the second time I did it. A9LH saved me **(TO AVOID BRICKING PLEASE KEEP YOUR BACK UP FROM JUST BEFORE THE EDIT AND IF YOU WANT TO RE INJECT AN EDITED HOME MENU THEN YOU MUST RESTORE THAT NAND THEN YOU CAN EDIT AGAIN OR ELSE YOU BRICK INSTANTLY))** . Or your can do it on your EmuNand, but be sure to also backup your EmuNand before.

◘ Download:My master zip folder which comes with everything you need.

◘ Download, with 3DNUS (In the master) the CIA of your HomeMenu (Latest Version):
*Just enter the currently available OFW by nintendo followed by the region

Eg; 11.6.0-39U 
	11.6.0-39E 
	11.6.0-39J 
JPN: 0004003000008202 (Homemenu CIA title)

USA: 0004003000008F02 (Homemenu CIA title)

EUR: 0004003000009802 (Homemenu CIA title)

◘ Rename the CIA  to HomeMenu.cia

◘ place it into your SD card either in D9 folder for decrypt9 or wherever else for Godmode9.

◘ Decrypt it using Decrypt9 -> Game Decryptor Options -> CIA Decryptor (Deep)
OR GodMode9 -> (A) on CIA -> CIA image options... -> Decrypt file (...) -> Decrypt inplace.

◘ Take now the decrypted CIA and put it in the HomeMenuEdition folder (included in master).

◘ Run my included tool,it has the options to extract all files from the cia AND decompress all the LZ11 files at once voiding the need for 3ds explorer.

♥ Most of the files are LZ11 compressed, you should decompress them before editing, then recompress them when finished editing.

♥ Now edit to your desire.

(All your edits will be done in the "Edit" window of MSBT Editor Reloaded (text like shutdownscreen or homemenu) or a hex editor (fonts or colours) and to open them in MSBT you just drag the file onto msbt editor in the folder and it should open :) )

♥ in "MSBT Editor Reloaded". Once a file is edited, you need to recompress it. Just use the Compressor / instead Decompressor from

 my home menu tool in the folder "HomeMenuEdition".

♥ Use the tool again and choose to rebuild the CIA, All your files should be packed in a new cia.

♥ HomeMenu_Edited.cia (even if you choose the option to place it onto the SD automatically (Which will try to find the folder D9Game on SD)).

♥ Encrypt HomeMenu_Edited.cia using Decrypt9 -> Game Decryptor Options -> CIA Encryptor (NCCH)
OR Encrypt HomeMenu_Edited.cia using Godmode9 -> (A) on HomeMenu_Edited.cia -> CIA image options... -> Encrypt file (...) -> Encrypt inplace.

♥ Once the CIA is encrypted, then you can install it using your preferred method of cia installation ex. FBI. No need to delete the previous CIA, install it will overwrite the old one.

♥ Reboot. Then pray or have A9LH/B9S. Check if you see your edits.

♥♥♥ Many thanks to the GBATemp community, Asia81, and a few more honourable mentions for the programs to have made this possible. ♥♥♥
