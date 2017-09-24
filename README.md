******CURRENT WARNING TO ALL WHO FOLLOW THIS! DO NOT EDIT TEXT YET, ONLY COLOUR! THERE WAS LOTS CHANGED TO NFIRM SINCE LAST I DID THE FIRST GUIDE AND SO FAR EDITING TEXT JUST PROVIDES AN ARM11 CRASH. I AM CURRENTLY LOOKING INTO HOW TO GET AROUND WHATEVER IS CAUSING THE ISSUE AND WILL UPDATE THE GUIDE AND FILES AGAIN ONCE IT IS SOLVED.******



WARNING: This will affect your HomeMenu, it's a critical core of the 3DS. Be sure to have a HardMod/NTRBoot, or A9LH/Boot9Strap NAND backup ready to recover a BRICK (I used it once, I got a brick the second time I did it. A9LH saved me (TO AVOID BRICKING PLEASE KEEP YOUR BACK UP FROM JUST BEFORE THE EDIT AND IF YOU WANT TO RE INJECT AN EDITED HOME MENU THEN YOU MUST RESTORE THAT NAND THEN YOU CAN EDIT AGAIN OR ELSE YOU BRICK INSTANTLY)) . Or your can do it on your EmuNand, but be sure to also backup your EmuNand before.

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

◘ Run Part1.bat, it will extract all decrypted files, then it will extract them.


(If you do not get all of the extracted folders, then edit both .bat files Part 1 & Part 2 To match the

♥ SystemApp.0000.00000087(82/84) (the last digits are based on region 82 (might be wrong the error system app will show right number (Jp?) 87 (US?) 84 (EU?) that first extracted so that it will match your specific region.)

♥ Now edit to your desire.

♥ Most of the files are LZ11 compressed, you should decompress them before editing, then recompress them.

(All your edits will be done in the "Edit" window of MSBT Editor Reloaded or a hex editor and to open them in MSBT you just drag the file onto msbt editor in the folder and it should open :) )

♥ 2 Things: DSDemcp GUI in 3DS explorer to decompress the menu_msbt_LZ.bin located in the folder 'Message', then the LZ11 decompressor

♥ in "MSBT Editor Reloaded". Once a file is edited, you need to recompress it. Just use the Compressor / instead Decompressor from

 DSDemcp GUI in 3DS explorer, then fix the file name, and delete the old compressed and the uncompressed.

♥ Start Part2.bat. No need to repack your RomFS, it will be done automatically. All your files should be packed in a new cia

♥ HomeMenu_Edited.cia.

♥ Encrypt HomeMenu_Edited.cia using Decrypt9 -> Game Decryptor Options -> CIA Encryptor (NCCH)
OR Encrypt HomeMenu_Edited.cia using Godmode9 -> (A) on HomeMenu_Edited.cia -> CIA image options... -> Encrypt file (...) -> Encrypt inplace.

♥ Once the CIA is encrypted, then you can install it using your preferred method of cia installation ex. FBI. No need to delete the previous CIA, install it will overwrite the old one.

♥ Reboot. Then pray or have A9LH/B9S. Check if you see your edits.

♥♥♥ Many thanks to the GBATemp community, Asia81, and a few more honourable mentions for the programs to have made this possible. ♥♥♥
