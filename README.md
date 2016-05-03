# MenuDump

WARNING: This will affect your HomeMenu, it's a critical core of the 3DS. Be sure to have a HardMod, or A9LH for recover a BRICK (I used it once, I got a brick the first time I did it. A9LH saved me) . Or your can do it on your EmuNand, but be sure to also backup your EmuNand before.

Download:My master zip folder which comes with everything you need.

Download, with 3DNUS the CIA of your HomeMenu (Latest Version):

JPN: 0004003000008202 v27648

USA: 0004003000008F02 v25600

EUR: 0004003000009802 v24576

Rename the CIA HomeMenu.cia.

Decrypt it using Decrypt9 -> Game Decryptor Options -> CIA Decryptor (Deep).

Take now the decrypted CIA and put it in the HomeMenuEdition folder.

Run Part1.bat, it will extract all decrypted files, then it will extract them.

(If you do not get all of the extracted folders, then edit both .bat files *Part 1 & Part 2* To match the

SystemApp.0000.00000083(82/84) that first extracted so that it will match your specific region.)

Now edit to your desire.

Most of files are LZ11 compressed, you should decompress them before editing, then recompress them.

(All your edits will be done in the "Edit" window of MSBT Editor Reloaded)

2 Things: DSDemcp GUI in 3DS explorer to decompress the menu_msbt_LZ.bin located in the folder 'Message', then the LZ11 decompressor

in "MSBT Editor Reloaded". Once a file is edited, you need to recompress it. Just use the Compressor / instead Decompressor from

DSDemcp GUI in 3DS explorer, then fix the file name, and delete the old compressed and the uncompressed.

Start Part2.bat. No need to repack your RomFS, it will be done automatically. All your files should be packed in a new cia

HomeMenu_Edited.cia.

Encrypt HomeMenu_Edited.cia using Decrypt9 -> Game Decryptor Options -> CIA Encryptor (NCCH).
 
 
Once the CIA is encrypted, then you can install it. No need to delete the previous CIA, install it will overwrite the old one.

Reboot. Then pray or have A9LH. Check if you see your edits.


Many thanks to the GBATemp community, Asia81, and a few more honourable mentions for the programs to do have made this possible.
