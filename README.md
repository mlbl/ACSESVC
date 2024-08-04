I've written a very simple C#.NET app that allows you to change the Amoury Crate SE Startup Video/Animation for the new **Armoury Crate SE 1.5** release that comes with the Ally X and was also released for the OG Ally 2-3 weeks ago.

Work with:
- Rog Ally (2023)
- Rog Ally X

Pre-requisites
- Armoury Crate SE 1.5 to be installed
- DotNet 8.0 Desktop Runtime (link available below)

Take note of the following:

1) It is very basic and not fully tested, but I did some quick tests - and only started coding this app about 24 hours+ ago.

2) **You are required to do these steps first before using the tool**: Go to the content platform section in the "settings" area in armory crate as per below screenshot.

![image](https://github.com/user-attachments/assets/732ab63f-42a0-4cf1-af64-1466ea98909e)

Then you select a startup video - say starfield - download it and select it.

3) Download my Armoury Crate SE Startup Video Changer tool here (it required dotnet 8.0 desktop runtime)

Download Link: [Releases](../../releases)

**TIP**: There's also a startup-videos-collection zip you can use to get you started. I personally created / trimmed / mixed the music in some of them - mainly those that have the word "ally" in them.

DotNet 8.0 Desktop Runtime download link: https://aka.ms/dotnet-core-applaunch?framework=Microsoft.NETCore.App&framework_version=8.0.0&arch=x64&rid=win10-x64&gui=true

4) Launch the tool (it will direct you to download DotNet 8.0 desktop runtime if you don't already have it installed. Interface:

![image](https://github.com/user-attachments/assets/e1c4e86b-5239-4582-9e3f-88401fcd0735)

5) Select a video file (MP4 file type and make sure the MP4 file is either h264/h265 encoded and nothing else)

6) Select destination folder. My tool/app will try to auto-detect your armoury crate SE user content folder. You should see folder(s) with 3 digit numbers if the auto-detection is successful. Examples:

- 353 corresponds to **GhostRunner**
- 352 corresponds to **Cult of the lamb**
- 358 corresponds to **Robocop**
- 353 corresponds to **Starfield**

So if you selected starfield in the original content platform section in Armoury Crate SE, you should choose 353 as your Destination Folder.

Then click on "Copy File" button and it should be done.

It's that simple.

Your original Mp4 file will be saved in a subfolder called "original" (example - 353\original) just in case you want to restore it.

NOTE: When using the tool, the Armoury Crate settings area to select a new startup video would not load up properly. I'm trying to figure out how ASUS formats these files and actually reads some of the information, so if you have any information about that - let me know.

Also take note the destination folder's MP4 file (ex: starfield_backup.mp4) will be made read-only during the copy file process - this is to prevent Armoury Crate from restoring it's original MP4 file (it's a "hack" or "workaround" to that problem).

Final notes:
- Source code is really messy and unoptimized, don't expect it to be for a less than 2 days work
- Plan to clean it up in the future

Hope that makes sense.

Please give the tool a try and let me know if you have any questions or issues. Also please upvote this thread, so that others can benefit from it.

If you wish to buy me a coffee:
https://www.buymeacoffee.com/mlbl
