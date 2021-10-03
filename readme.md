# Download

[Release.zip](https://github.com/time007gc/CatHack/files/7272479/Release.zip)

# Media

https://user-images.githubusercontent.com/60156453/135706903-2a95dd1b-000d-4d97-b097-05c78fa593f3.mp4


https://user-images.githubusercontent.com/60156453/135706978-167eff22-bdd3-4439-ba49-f06de844729e.mp4


https://user-images.githubusercontent.com/60156453/135707337-339120eb-6e05-41f1-aa06-f0818d6ff3fd.mp4

# CatHack
An open source external orbwalker for league of legends.
Please note this is not a GOOD orbwalker. This is just a project im working on.
If you want to improve anything from this code, fork my repo and go at it!
Also, CatHack's system to take screenshots is **REALLY** fucking slow. Expect ~30 fps loss or greater.
I am planning on removing it as you can just hardcode your ping into the orbwalking calculation.

# How to use
1. Download the Release.zip from the repo (make sure to unzip CatHack somewhere in your C drive)
2. From the Release folder, put the Tessdata folder into your C: drive' documents folder. **(IT HAS TO BE IN C:)**
3. Launch CatHack
4. Go into the "Player" tab
5. Click on New Config
6. Open the other window containing the ping screenshot tool, and click the "Take MS Screenshot" button
7. Position the gray box around your ping in league. It should look like this: 

![alt text](https://i.gyazo.com/4f89b7cd4731f088c20f7ab17ee418a5.png "User ping position")

8. After you have successfully positoned the box, press F to save it. Also make sure to choose a keybind for CatHack to orbwalk with. (I recommend X)
9. Go back into the main menu of CatHack, go into orbwalking and toggle it on. 

![alt text](https://i.gyazo.com/afb814016279cf68b9b0c8860d852801.png "Orbwalk")

10. Open up a practice tool game and test it. 

# Usage remarks
CatHack automatically saves settings, but anytime you close it you need to take the ping screenshot again.
If you have already saved a screenshot, simply go into "Player" tab and click on Use Config and THEN take the picture (you do not need to reposition the box).
After, open every other tab (orbwalk and champions), close them, and then you are good to go!

If you play league on 1920x1080, use the userData.txt file from the repo. It has the perfect position for ping (assuming you only have 2 digit ping)
Place the text file in your documents folder, just like tessdata should be.

**I am not going to help you with compiling. Do not message me about it. Google is 10000x more useful**
**than i'll ever be. Trust me. This shit is mostly pasted anyways.**

# Todo
- Orbwalker always misses on ping change
- Pixelsearch doesn't properly hover over enemies if they are too close
- Pixelsearch RARELY targets something other than champions