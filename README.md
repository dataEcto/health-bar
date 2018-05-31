# health-bar
Part of my personal Summer Game Making Marathon (TM of course). A game where you have to recover your health by spamming that space bar.

WHAT IS THE SUMMER GAME MAKING MARATHON?
Recently, I have finally gotten into creating games within Unity. It's a very fun process, but I also noticed that I can get
very ambitous. I tend to want to work on ideas that can't really be handled by one person alone, and during my Game Development class, I end up not having a lot of time left to work on what I wanted to work in. Plus, I'm also a perfectionist so I sometimes just don't want to show my work at all. I want to change that!

Over my Summer break, I want to see how many small games I can create, and see what the results are. These Repos will be a in progress look at my work.


HEALTH BAR GAME (Name in Progress)

5/28/18

I decided to create a game that is based off on that scene in various Metal Gear games where Snake gets tortued, and the player must mash a button to keep his health bar up while his health bar drains. It's not the most super impressive game over, but hey it's simple.
When I created my first few games back in my Game Dev class, I realized how much I go inbetween implementing certain mechanics in them.
For example, the Sneaking Game I made had a lot of focus on the GUARD AI and not much else. I decided to see what I can do if I focus on ONE Mechanic on the game, which is this Health Bar going down and getting refilled.

So far, I have the health bar working. It has 2 important functions: DealDamage and RestoreHealth, both which work as expected.
Now, however, I need to find a way to make DealDamage work based on time rather than button input. This should be easy, I can probably just use what I used in the past (urgh i forgot the name of it though) to get it to work.


5/29/18

This probably isn't really the best way to track my progress, most likely? lol i dont really know. I might as well commit to this.
After a busy day, I started working on making sure that the dealdamage function worked on a timer. I could have used a coroutine, but I felt as though the time to learn the code would be too much for me, so I stuck with using a simple float that counts down as a Timer.
It works as expected. Actually, the DealDamage function used to do 1 dmg per frame, but that drained the bar down so fast. Right now, I put it at a small 0.1f to make it more reasonable. 

Testing it out gave me flashbacks to the tortue scenes alright. God darn, where those annoying sometimes, but oddly funish? Who knows.

Things I really need to do: 1) Code that makes dealing damage stop after a while 2)another deal damage function(?) that increases damage done 3) and then code runs that function.

I THINK what I can do is just make each difficulty level a new scene. Saves me time, I reckon.

5/30/18
Most of the changes are within my pushes, so I won't list them here.  I think I'll just write down what I'm going to need to implement. 
I'll need some more levels of difficulty, and fix up those transitions and make it more consistent (which should be pretty easy to do though).
I still need the aesthetic for the game. I'm not sure if I want to do the gritty tortue theme. Maybe a anti bullying kind of deal i dont  know. I can ask.

This all reminds me of that Nintendo Tofu prototype...

