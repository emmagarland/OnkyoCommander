# README #

This is a very basic starting point with no tests, authentication or injection protection. It is just for play! But it does send commands to my Onkyo TX-NR515 following the Integra Serial Communication Protocols for AV Receiver.
Feel free to fork, pull, extend as you will. There are probably other more advanced ones out there but the conversation came up a few times about the code for this and I wanted to at least get it on the public domain!


### What is this repository for? ###

* Power Onkyo on and off, volume up and down, more commands to follow!
* My Onkyo Version is TX-NR515

### How do I get set up? ###

* It contains a Windows App and a very basic Web API to post commands to.
* Configuration - don't forget to build and you can use something to Post to the web api or use the Windows App
* Dependencies - nuget, will add more in future
* Deployment instructions - setup in IIS or however you prefer, or just run in IISExpress

### Contribution guidelines ###

* There are no tests yet, but happy if you write some!
* Wouldn't probably pass a code review but again it is just for play but happy for refactorings!

### Who do I talk to? ###

* http://twitter.com/emmagarland

Thanks to the following articles for inspiration/code snippets:

* https://www.autoitscript.com/forum/topic/117300-help-please-with-tcpip-script-to-control-onkyo-receiver/
* https://github.com/miracle2k/onkyo-eiscp