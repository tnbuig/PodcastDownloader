## Welcome To "Podcast Downloader" Project
![ApplicationLook](/ApplicationLook1.png)

#### Application is in its final stages but not ready for public use.
> code contribution is welcome as well as suggestions and comments
- [x] Coding Main UI Moduls.
- [x] Coding Backhand moduls stracture and test main functionalty.
- [X] Start connecting the pieces to a working software and manual testing.
- [ ] Fill in the gaps in the logic paths between UI and data base.
- [ ] Complete implementation of Access layer interface.
- [X] Moving web access work to background threads.
- [ ] Add Tests.
- [ ] Create Setup project.
- [ ] Release final product.

I tried to keep the the application in general and the UX in particular simple and self explanatory as possible.

I feel that today UI should be inviting - easy to remember and fun to learn.
the first time might take few second till things will clear out but from the second time the user will be completly comfterball knowing that there isn’t any hidden configuration or parts of the application that he missed.

The application tries to solve one problem only but to do it well - and I hope the user will share that feeling.

![Application Performance](/Perfromance_5030_From_15_Feeds_In_35_Seconds.png)
As you can see - test run for Scan 13 Rss Feeds and storing in Data base the data for 5030 episodes including publish Date and Download link.
the timing was 35 seconds which most of it spent on reading from the internet and depend on your internet speed.


I have tried to use best practices for WPF and DB 
```
Technology is mainly .NET WPF C# MVVM Architecture 
The following Third parties were used:
1. Log4Net
2. SQLite
3. NSubstitute.
4. MVVM Light
5. IOC Container
```
Other free Application out there are : 
1. [hermespod](http://hermespod.com/)
2. [Juice](http://juicereceiver.sourceforge.net/download/)
