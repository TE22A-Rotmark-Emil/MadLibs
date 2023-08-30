Console.WriteLine("Write a Name: ");
string? nameofuser = Console.ReadLine();

Console.WriteLine("Do you exercise?: ");
string? Exercise = Console.ReadLine();
Exercise = Exercise.ToLower();
if (Exercise != "yes" && Exercise != "no") {
    while (Exercise != "yes" || Exercise != "no") {
    Console.WriteLine($"Invalid Response. Write either yes or no, not '{Exercise}'.");
    string? insideVariable = Console.ReadLine();
    if (insideVariable == "yes" || insideVariable == "no") {
        insideVariable = nameofuser;
        break;
    }
}
}

Console.WriteLine("Write a type of vehicle: ");
string? vehicleDeath = Console.ReadLine();

Random generator = new Random();
int Survive = generator.Next(6);
while (Survive is 0) {
    Console.WriteLine(Survive);
    int TempNumber = generator.Next(6);
    Survive = TempNumber;
}
Console.WriteLine(Survive);
while (Exercise is "yes") {
    if (Survive == 1) {
        Console.WriteLine($"It was just like any other Monday. {nameofuser}, an avid athlete, went outside to go for a walk. Suddenly, out of nowhere, a {vehicleDeath} approached {nameofuser} at 4800km/h. They did not survive the impact.");
        Console.ReadLine();
        break;
    }
    else if (Survive == 2) {
        Console.WriteLine($"It was NOT a normal Wednesday. {nameofuser} woke up grumpy, depressed, and desheveled. They decided that a morning walk would be an appropriate way to start their morning. However, to their dismay, a {vehicleDeath} was parked on the side of the road that {nameofuser} most preferred.");
        Console.WriteLine($"{nameofuser} died immediately, due to sadness.");
        Console.ReadLine();
        break;
    }
    else if (Survive == 3) {
        Console.WriteLine($"{nameofuser}, despite their athleticism, was killed by a {vehicleDeath}");
        Console.ReadLine();
        break;
    }
    else if (Survive == 4) {
        Console.WriteLine($"{nameofuser}? What kind of a name is that? {nameofuser}. Sounds made up. And {vehicleDeath}? That's hardly anything to even bat an eye to.");
        Console.WriteLine($"A {vehicleDeath} couldn't kill a fly if it tried. So, like, you survive, and stuff. Grats.");
        Console.ReadLine();
        break;
    }
    else if (Survive == 5) {
        Console.WriteLine($"{nameofuser} woke up on a cold and soothing Thursday evening. Scrubbing their eyes, they faintly move to eye the clock. If they prepare now, they'll still be able to make it to work.");
        Console.WriteLine($"With their courage and might, they immediately get out of bed after a measly 38 minutes of contemplation. After preparing the necessities, {nameofuser} steps outside to enter their {vehicleDeath}.");
        Console.WriteLine($"- 'Hey {nameofuser}!', a familar voice said. {nameofuser} turn and twist, trying to locate the source of the noise. It's their neighbour! A gentle wave is enough to end the peaceful confrontation.");
        Console.WriteLine($"After a mere 2 hour car ride, {nameofuser} arrives at work. 'You're late,' a familiar voice insists. 'No,' {nameofuser} reply, refusing to accept the responsibility of their own actions. 'It was windy.'");
        Console.WriteLine($"'You're fired.' A thunderous slam startles {nameofuser}, making them take an involuntary step back. 'Well!', they reply to the locked door. 'I didn't even like this job anyway!'. They scurry away, crying. But, hey, at least they didn't die.");
        Console.ReadLine();
        break;
    }
}
while (Exercise is "no") {
    if (Survive == 1) {
        Console.WriteLine($"{nameofuser} couldn't resist the urge to kick a {vehicleDeath}, which was parked solemnly on the side of the road. As a result of their low physique, {nameofuser} suffered a major fracture in their small toe.");
        Console.WriteLine($"Their toe split into eight separate and equally large segments, each piece flying into random directions. 'You have to retrieve the toe pieces!', said an unfamiliar voice.");
        Console.WriteLine($"{nameofuser} died out of confusion and anger.");
        Console.ReadLine();
        break;
    }
    else if (Survive == 2) {
        Console.WriteLine($"Eight days have passed since the last time {nameofuser} saw the light of day. It's over. As famously stated by Scientist and World Record Holder for most beers consumed in eight minutes, Dr. Johnston Carl Flapperton, one cannot survive without sunlight for more than 192 hours.");
        Console.WriteLine($"Gasping for air and begging for mercy, {nameofuser} saw a familiar figure. In front of them stood a {vehicleDeath}, simply watching. Observing.");
        Console.WriteLine($"'{vehicleDeath}!', they exclaimed, 'save me from this eternal darkness! I can't take it anymore!'. A chilling laughter's reverberation could be felt throughout the entire facility. 'Save you?', the apparently sentient {vehicleDeath} said. 'SAVE YOU?'");
        Console.WriteLine($"Silence, total silence, only occasionally broken by snippets of laughter or gags. 'What's wrong with you?', {nameofuser} eventually mustered, faintly under their breath. The laughter stopped. 'Me?', {vehicleDeath}, who, again, apparently is sentient, questioned. 'ME? WHAT'S WRONG WITH M E ?'. The laughter continued, seemingly echoing forever.");
        Console.WriteLine($"The laughter calmed, and the voice from the still-somehow-sentient-{vehicleDeath} shined through. 'You're sick. Twisted.'. {nameofuser} could only sit and watch as {vehicleDeath} stared into their eyes. {vehicleDeath}'s cold, lifeless eyes. Echoing a thousand emotions, yet not protruding a single one. 'You're a mouse, a rat. Trash, less than trash. Garbage. Worthless.', {vehicleDeath} kept going; 'Worthless.' {vehicleDeath} raised a wheel. 'WORTHLESS!'");
        Console.WriteLine($"{nameofuser}'s vision began to blur, but, in their final breath, they managed to meet {vehicleDeath}'s eyes, and state, in a final, exasperated gasp: 'I'm sorry.'");
        Console.ReadLine();
        break;
    }
    else if (Survive == 3) {
        Console.WriteLine($"'Ow!' said {nameofuser}. Their legs aching, they let out an exasperated scream. 'W-wait!', they mustered. A sigh could be heard in the distance.");
        Console.WriteLine($"Sir Hedgeworth Longsword Decarius II started to regret accepting {nameofuser}'s offer to run a marathon together. Suddenly, in the distance, an engine revving up could be heard. Sir Hedgeworth Longsword Decarius II turned to look at it, but was struck before he could even turn.");
        Console.WriteLine($"'HEDGEWORTH!', {nameofuser} cried out. Sir Hedgeworth Longsword Decarius II raised a finger reluctantly, 'That's Sir Hedgeworth Longsword Decarius II to you.', he said.");
        Console.WriteLine($"A blank expression grew on {nameofuser}'s face. The apparent grief wiped away as if they'd never even felt grief to begin with. 'Shut up', they said. Sir Hedgeworth Longsword Decarius II died, with his finger still eagerly raised.");
        Console.WriteLine($"The revving continued. {nameofuser} turned towards its origin, but before they could even finish half a rotation, a {vehicleDeath} had already ran them over.");
        Console.WriteLine($"{nameofuser} died immediately.");
        Console.ReadLine();
        break;
    }
    else if (Survive == 4) {
        Console.WriteLine($"Here we go again. Who's this? What's your name? (...) '{nameofuser}'? PFF HAEUGH Hah hha ha. That's hilarious. Who came up with it? Your parents? Hahahahahaha, oh my god, that's good. Oh, jeez.");
        Console.WriteLine($"Okay, no, but, seriously, what's your name? (...) Oh. Oh, you weren't kidding? Wow. Okay. And a... what was it? {vehicleDeath}? Yeah, right. You're making this stuff up. Entirely ridiculous. That's not real, sorry.");
        Console.WriteLine($"And you... don't exercise? Well, with a name like that, I'm not really surprised. It would be nice to have something new every now and again, though. Oh well. (...) What's wrong? Waiting for some kind of story or smth?");
        Console.WriteLine($"(...) Okay, you're seriously not going away? Ughh... Alright. Here you are:");
        Console.WriteLine($"{nameofuser} (a sound of suppressed laughter could be heard from a distance) walked out of their home. It was a Friday, and they were late for school.");
        Console.WriteLine($"{nameofuser} (a suppressed 'pfft' could be heard from a distance) ran into their {vehicleDeath}. They arrived 13 minutes late. They approached the front door and wiggled it, then dragged. Nothing happened. They shook it, kicked it, dragged it harder. Nothing happened. Eventually a cleaner walks by, so {nameofuser} approaches them in hopes for answers.");
        Console.WriteLine($"'Hey, i-', before they could finish their sentence, the cleaner cuts them off. 'Study day.' {nameofuser} blinked twice, slowly, then walked back to their {vehicleDeath}. With an exasperated sigh, {nameofuser} drove home.");
        Console.WriteLine($"The end.");
        Console.ReadLine();
        break;
    }
    else if (Survive == 5) {
        Console.WriteLine($"Eyes closed. Everything's dark. {nameofuser} could feel a putrid smell potruding throughout the entire facility. A wretched smell of iron, blood, and body odour filled the room. {nameofuser}, opening their eyes for the first time in a long time, noticed that they were surrounded by small robotic replicas of people from their childhood.");
        Console.WriteLine($"{nameofuser}, in an act of genius, did a sick backflip on top of their {vehicleDeath}. There was applause, every single robotic recreation of past sensations stood up, erupting in jubilation.");
        Console.WriteLine($"The applause ended. The robotic masses of metal and blood lead {nameofuser} out of the facility, unharmed. The {vehicleDeath} was destroyed, for it could not perform a backflip quite as spectacular as that of {nameofuser}.");
        Console.ReadLine();
        break;
    }
}