# WARNING: 
This will affect your HomeMenu, it's a critical core of the 3DS. Be sure to have a HardMod/NTRBoot, or A9LH/Boot9Strap NAND backup ready to recover a possible **BRICK**. A9LH saved me **(TO AVOID BRICKING PLEASE KEEP YOUR BACK UP FROM JUST BEFORE THE EDIT)**. Or your can do it on your EmuNand, but be sure to also backup your EmuNand before.

◘ Download: My master zip folder which comes with everything you need.

◘ Make sure you have the latest GodMode9 Installed https://github.com/d0k3/GodMode9/releases

◘ Copy Mod_HomeMenu.gm9 from the zip onto your 3ds SD card in the gm9/scripts folder

◘ Place your SD back into your 3ds, and boot into godmode9

◘ Once godemode9 boots, press the home button, go to scripts, and run Mod_HomeMenu

◘ When prompted, select "Grab CIA"

◘ Godmode9 will work it's magic, and create HomeMenu.cia in gm9/out on your SD

◘ Power off your 3ds, and insert your SD into your computer

◘ Copy the HomeMenu.cia from your SD card (gm9/out) to the homemenuedition folder you extracted from the zip earlier

◘ Now simply run my Home Menu Tool i provided from within that folder and it will list you all steps. For convenience i added an option to do all at once so extract rebuild and decompress all the LZ files at once. and auto place the file when done everything back into your SD card.

◘ Now you do your edits.
For sleep.LZ colour edits (the power off screen) you can simply use the SleepLZColorEditor Tool found within the MenuDump pack.
You can set your own colours, or use either one of the two provided example colour theme files or another colour theme file you find online

For text edits, You can use MSBT Editor, which is also included in the MenuDump pack.
The file you'll want to open is menu_msbt.LZ, found in the ExtractedRomFS/message/(your language) folder.
for the sleep menu (the power off screen we color edit above) You'll want to edit the lau_press_pow* strings



◘ Go back to your home menu tool prompt that is still running, and press any key to continue

◘ The files will get recompressed, and rebuilt back into a CIA, and then automatically copied to your 3ds SD card if it's still in the computer

◘ If it doesn't automatically copy, then manually copy the HomeMenu_edited.cia into the gm9/out folder on your SD card

◘ Boot into Godmode9. Press the home button, then select scripts, and run Mod_HomeMenu

◘ When prompted, select "Install", and then select the home menu cia you wish to install. It will ask if you want to create a sysNAND backup first. I recommend doing this the first time you run the script. Once the script completes, you can reboot

♥ Reboot. Then pray or have A9LH/B9S. Check if you see your edits.

◘ xXx If your console successfully boots, then congrats! You now have a custom home menu!

If your console doesn't boot, then don't worry! TheCyberQuakes script is designed to be as safe as possible, and we have a contingency plan for this!

Boot into godmode9, press home button, select scripts, and run Mod_HomeMenu. Select Restore when prompted

That's it! Now your home menu should be back to it's original version (or whatever version it was when you first ran the install_homemenu script). You can also use this step to remove your edits at any point if you want to.


♥♥♥ Many thanks to the GBATemp community, Asia81, & TheCyberQuake and a few more honourable mentions for the programs to have made this possible. ♥♥♥
