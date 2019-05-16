#Project - Google Photos Video Edit

##Purpose

1. Add resume experience, and stand out in video related teams.
2. Guide what to learn, and put them together to solve one realistic problem.

##Target
#####Stage1
Clarify all related skills needed to finish the project by finishing the project document.

#####Stage2
Finish key function APIs and test cases.

#####Stage3
Finish functions

##KeyPoint
#### 1. videos upload and store
1. [ ] Where the videos from
	- [ ] Computer : _Mac_ | Windows | Linux
	- [ ] iPhone
	- [ ] Android
	- [ ] Camera : SD card
2. [ ] Where the videos go
	- [ ] _Cloud : AWS | Azure | Google Cloud_
	- [ ] Original place : store where they are from
3. [ ] Upload APIs
3. [ ] Store stratagem 



#### 2. videos clip and joint 
> command line :

~~~ 
clip :

$ ffmpeg -i input.mp4 -c copy -ss 00:00:15 -t 00:00:10 output2.mp4

merge:
$ echo file out_Part_1.mp4 > mylist.txt
$ echo file out_Part_2.mp4 >> mylist.txt
$ ffmpeg -f concat -i mylist.txt -c copy out_merged.mp4

~~~

#### 3. videos compress
1. [ ] _Tech_ Compress methods
2. [ ] _Tech_ Compress target


#### 4. videos play on the cloud/local
1. [ ] Preview the video when select 
	- [ ] Show the thumbnail of the video
	- [ ] Show the total time duration
	- [ ] Preview (not necessary, can preview at next step)
2. [ ] Show the video before clip 
	- [ ] Preview video while editing
	- [ ] Show the timestamp of the video (enable to keep the timestamp down)
	- [ ] show the clip range 	
3. [ ]Show the video before merge
	- [ ] show the merged pieces
	- [ ] show the total time duration


#### 5. [Advance] user interface
#### 6. [**Advance] 

---

- 05.15 --- v1.0 demo 

> define demo functions
> define Video class
>> ref :
>>	[HOW TO RETRIEVE THE VIDEO PROPERTIES(java)](http://www.javacreed.com/how-to-retrieve-the-video-properties/)
>> [Inspect a video file with Xuggler(Xuggler)](https://examples.javacodegeeks.com/desktop-java/xuggler/inspect-a-video-file-with-xuggler/)
>>[ffprobe,ffplay ffmpeg常用的命令行命令](https://juejin.im/post/5a59993cf265da3e4f0a1e4b)
>>[ffmpeg常用参数一览表](https://blog.csdn.net/maopig/article/details/6610257#)
>> [How to Save the Output of a Command to a File in Bash (aka the Linux and macOS Terminal)](https://www.howtogeek.com/299219/how-to-save-the-output-of-a-command-to-a-file-in-bash-aka-the-linux-and-macos-terminal/)
>> [101 Bash Commands and Tips for Beginners to Experts](https://dev.to/awwsmm/101-bash-commands-and-tips-for-beginners-to-experts-30je)
>> [Java - Period and Duration](https://docs.oracle.com/javase/tutorial/datetime/iso/period.html)
>> [Java 8 – Period and Duration examples](https://www.mkyong.com/java8/java-8-period-and-duration-examples/)
>> [How to parse JSON in Java
](https://stackoverflow.com/questions/2591098/how-to-parse-json-in-java)
