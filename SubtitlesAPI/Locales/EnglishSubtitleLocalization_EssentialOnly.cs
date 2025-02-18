﻿using System;
using System.Collections.Generic;

namespace SubtitlesAPI.Locales;

public class EnglishSubtitleLocalization : ISubtitleLocalization
{
    public string Locale => "en";

    public Dictionary<string, string> Translations => new(StringComparer.OrdinalIgnoreCase)
    {
        { "AirHorn1", "Air horn plays" },
        { "AirHornFar", "Distant air horn plays" },
        { "AlertedSFX", "Nutcracker aims" },
        { "AlertHUD", "Warning alarm" },
        { "Angered", "Rustling" },
        { "AngryScreech", "Bug screeches" },
        { "AngryScreech2", "Bug screeches" },
        { "Applause", "Applause" },
        { "BaboonEnterFight", "Aggressive hawk" },
        { "BaboonKill", "Player is impaled" },
        { "BabyCry4", "Baby squalling" },
        { "BabyCry5b", "Baby squalling" },
        { "BabyCryFake", "Baby squalling?" },
        { "BabyCryFake2", "Baby squalling?" },
        { "BabyFootstep1", "Pattering" },
        { "BabyFootstep2", "Pattering" },
        { "BabyFootstep3", "Pattering" },
        { "BabyPuke", "Baby vomits" },
        { "BackDoorClose", "Door closes "},
        { "BackDoorOpen", "Door opens "},
        { "BalloonPop", "Balloon pops" },
        { "BalloonPopReverb", "Balloon pops" },
        { "BareFootstep1", "Footsteps" },
        { "BareFootstep2", "Footsteps" },
        { "BareFootstep3", "Footsteps" },
        { "BareFootstep4", "Footsteps" },
        { "BeeHiveIdle", "Bees buzzing" },
        { "BeesAngry", "Bees buzz angrily" },
        { "BeesDefensive", "Bees buzz defensively" },
        { "BellChimeAmbience", "Clock chimes faintly" },
        { "BellDinger", "Bell rings" },
        { "BeltBagUnzip1", "Bag zips" },
        { "BeltBagUnzip2", "Bag zips" },
        { "BeltBagUnzip3", "Bag zips" },
        { "BeltBagZipUp1", "Bag zips" },
        { "BeltBagZipUp2", "Bag zips" },
        { "BigDoorClose", "Door closes" },
        { "BigDoorOpen", "Door opens" },
        { "Boombox6QuestionMark", "Boombox plays upbeat music" },
        { "BoomboxMusic1", "Boombox plays upbeat music" },
        { "BoomboxMusic2", "Boombox plays upbeat music" },
        { "BoomboxMusic2TVVersion", "TV plays upbeat music" },
        { "BoomboxMusic3", "Boombox plays upbeat music" },
        { "BoomboxMusic4", "Boombox plays upbeat music" },
        { "BoomboxMusic5Zedfox", "Boombox plays upbeat music" },
        { "BoomboxStop", "Boombox stops" },
        { "BootStomp1", "Wooden Stomping" },
        { "BootStomp2", "Wooden Stomping" },
        { "BootStomp3", "Wooden Stomping" },
        { "BreakerBoxClose", "Breaker opens" },
        { "BreakerBoxOpen", "Breaker closes" },
        { "BreakerLever1", "Lever flip" },
        { "BreakerLever3", "Lever flip" },
        { "BreakTree1", "Tree breaks" },
        { "BreakTree2", "Tree breaks" },
        { "Breathe1", "Growling" },
        { "Breathing", "Breathing" },
        { "BridgeCollapse3", "Bridge collapses" },
        { "BridgeCollapseV2", "Bridge collapses" },
        { "BridgeCreak1", "Bridge creaking" },
        { "BridgeCreak2", "Bridge creaking" },
        { "BridgeCreak3", "Bridge creaking" },
        { "BridgeCreakHeavy2", "Bridge creaks unstably" },
        { "BroomSweep1", "Sweeping" },
        { "BroomSweep2", "Sweeping" },
        { "BroomSweep3", "Sweeping" },
        { "BroomSweep4", "Sweeping" },
        { "BugWalk1", "Bug skitters" },
        { "BugWalk2", "Bug skitters" },
        { "BugWalk3", "Bug skitters" },
        { "BugWalk4", "Bug skitters" },
        { "BurrowingRumble1", "Ground rumbles" },
        { "BurrowingRumble2", "Ground rumbles" },
        { "BurrowingRumble3", "Ground rumbles" },
        { "BurrowingRumbleLoud1", "Ground shaking "},
        { "BushWolfKill", "Player is eaten" },
        { "ButlerBeeSwarm", "Buzzing" },
        { "ButlerBuzzingAmbience", "Buzzing" },
        { "ButlerStep1", "Footsteps" },
        { "ButlerStep2", "Footsteps" },
        { "ButlerStep3", "Footsteps" },
        { "ButlerStep4", "Footsteps" },
        { "ButlerStep5", "Footsteps" },
        { "ButlerSuitRustle", "Rustling" },
        { "ButlerUntuckKnifeSFX", "Rustling" },
        { "BWCall3", "Fox shrieks" },
        { "BWCall3Far", "Fox shrieks distantly" },
        { "BWCall4", "Fox shrieks" },
        { "BWCall4Far", "Fox shrieks distantly" },
        { "BWGrowl", "Growling" },
        { "BWGrowl2", "Growling" },
        { "BWGrowl4", "Growling" },
        { "BWGrowl5", "Growling" },
        { "BWGrowl6", "Growling" },
        { "BWGrowlDragging1", "Growling" },
        { "BWStep1", "Pattering" },
        { "BWStep2", "Pattering" },
        { "BWStep3", "Pattering" },
        { "BWStep4", "Pattering" },
        { "BWStep5", "Pattering" },
        { "BWStep6", "Pattering" },
        { "CalmWater", "Lightly flowing water" },
        { "CashRegisterDing", "Cash register dings" },
        { "CaveDwellerAdultMove", "Crawling" },
        { "Caw1", "Hawk screeches" },
        { "CawScream1", "Hawk screeches" },
        { "CawScream2", "Hawk screeches" },
        { "CawScream3", "Hawk screeches" },
        { "CawScream4", "Hawk screeches" },
        { "CawScream5", "Hawk screeches" },
        { "CentipedeWalk", "Skitters" },
        { "ChatteringTeeth", "Chattering" },
        { "Chitter1", "Chittering" },
        { "Chitter2", "Chittering" },
        { "Chitter3", "Chittering" },
        { "Chuckle1", "Chirping" },
        { "Chuckle3", "Chirping" },
        { "Chuckle4", "Chirping" },
        { "Chuckle5", "Chirping" },
        { "ClickingMandibles", "Chattering" },
        { "ClingToPlayer", "Snare Flea clings" },
        { "ClingToPlayerLocal", "Snare Flea clings" },
        { "Clock1", "Clock plays melody" },
        { "Clock2", "Clock plays melody" },
        { "CloseDoorWooden1", "Door closes" },
        { "CloseDoorWooden2", "Door closes" },
        { "CloseDoorWooden3", "Door closes" },
        { "CloseMineDoor1", "Door closes" },
        { "CloseMineDoor2", "Door closes" },
        { "ClownHorn1", "Clown horn plays" },
        { "ClownHornFar", "Distant clown horn plays" },
        { "Collision_Maximum", "Crash" },
        { "Collision_Maximum2", "Crash" },
        { "Collision_Medium", "Clunk" },
        { "Collision_Medium2", "Clunk" },
        { "Collision_Medium3", "Clunk" },
        { "Collision_Minimal", "Thud" },
        { "Collision_Minimal2", "Thud" },
        { "CrackNeck", "Neck snap" },
        { "Cruiser_CutRopes", "Ropes snap" },
        { "Cruiser_EngineRev", "Engine stalling" },
        { "Cruiser_EngineStart", "Engine starts" },
        { "Cruiser_Explode", "Cruiser explodes" },
        { "Cruiser_HitObstacle", "Thud" },
        { "Cruiser_HitObstacle2", "Clunk" },
        { "Cruiser_HitObstacle3", "Crash" },
        { "Cruiser_Horn", "Cruiser horn blares" },
        { "Cruiser_OpenHood", "Hood opens" },
        { "Cruiser_PushPedalInPark", "Pedal fails" },
        { "Cruiser_PourOil", "Oil pouring" },
        { "Cruiser_Rolling", "Cruiser rolling" },
        { "Cruiser_ShutHood", "Hood shuts" },
        { "Cruiser_Skid", "Wheels skid" },
        { "Cruiser_Turbulence", "Cruiser struggles" },
        { "DisconnectLungDevice", "Apparatus disconnects" },
        { "DistantRumble1", "Distant rumbles" },
        { "DistantRumble2", "Distant rumbles" },
        { "DistantRumble3", "Distant rumbles" },
        { "DocileLocustBees", "Locusts Buzz" },
        { "DocileLocustBeesEvade", "Locusts disperse" },
        { "DoorClose", "Door closes" },
        { "DoorClose1", "Door opens" },
        { "DoorClose2", "Door opens" },
        { "DoorOpen", "Door opens" },
        { "DoorOpen1", "Door closes" },
        { "DoorOpen2", "Door closes" },
        { "DoorShut", "Door shuts" },
        { "DoorSlam1", "Door slams" },
        { "DoorSlam2", "Door slams" },
        { "DoorUnlock", "Door unlocks" },
        { "DoorUnlock2", "Door unlocks" },
        { "DoublewingFlap1", "Flapping" },
        { "DoublewingFlap2", "Flapping" },
        { "DoublewingFlap3", "Flapping" },
        { "DuckQuack", "Rubber duck quacks" },
        { "ElevatorJingle", "Elevator plays jingle" },
        { "EnterCooldown", "Cranking" },
        { "EmergeFromGround1", "Earth Leviathan attacks" },
        { "ExplodeHead", "Head explodes" },
        { "ExtensionLadderAlarm", "Extension Ladder expiring alarm" },
        { "ExtensionLadderExtend", "Extension Ladder extending" },
        { "ExtensionLadderShrink", "Extension Ladder shrinking" },
        { "FallInWater", "Splash" },
        { "Fart1", "Farting sounds" },
        { "Fart2", "Farting sounds" },
        { "Fart3", "Farting sounds" },
        { "Fart5", "Farting sounds" },
        { "FGiantEatPlayerSFX", "Player is eaten" },
        { "Fireplace", "Crackling" },
        { "Flamethrower", "Sizzling" },
        { "FlashbangExplode", "Flashbang explodes" },
        { "FlashlightClick", "Flashlight clicks" },
        { "FlashlightClickMini", "Light switch turns on" },
        { "FlashlightClickMini2", "Light switch turns off" },
        { "Fly", "Bug flying" },
        { "Footstep1", "Footsteps" },
        { "Footstep2", "Footsteps" },
        { "Footstep3", "Footsteps" },
        { "Footstep4", "Footsteps" },
        { "Footstep5", "Footsteps" },
        { "Found1", "Rustles" },
        { "Frighten1", "Creature frightened" },
        { "Frighten3", "Creature frightened" },
        { "GarageDoorSlam", "Garage door slams" },
        { "GhostDeviceFullyCharged", "Device is turned on" },
        { "GhostDevicePing", "Device is pinged" },
        { "GhostDeviceTurnOff", "Device is turned off" },
        { "GiantStomp1", "Giant stomps" },
        { "GiantStomp2", "Giant stomps" },
        { "GiantStomp3", "Giant stomps" },
        { "GiantStomp4", "Giant stomps" },
        { "GiantStomp5", "Giant stomps" },
        { "growl", "Dog growls" },
        { "Hairdryer1", "Hairdryer blows" },
        { "HairdryerFar", "Distant hairdryer blowing" },
        { "HangarDoorOpen1", "Ship door opens" },
        { "HangarDoorOpening", "Ship door opening" },
        { "HangarDoorShut", "Ship door shuts" },
        { "HoarderBugCry", "Hoarder bug cries" },
        { "HomemadeFlashbangPullCork", "Cork pops" },
        { "HUDSystemAlert", "Warning beeps" },
        { "ItemDropshipLand", "Item dropship lands" },
        { "ItemDropshipOpenDoors", "Item doorship door opens" },
        { "JackInTheBoxTheme", "Jester winding" },
        { "JackOLanternHit", "Evil cackle" },
        { "JesterStomp1", "Intense stomps" },
        { "JesterStomp2", "Intense stomps" },
        { "JesterStomp3", "Intense stomps" },
        { "JetpackThrust1", "Jetpack roars" },
        { "JetpackWarningBeep", "Warning beeps" },
        { "JetpackWarningBeep2", "Warning beeps" },
        { "KillPlayer", "Player is mauled" },
        { "KillPlayer_0", "Player is mauled" },
        { "KillPlayerSpring", "Player gets sprung" },
        { "KnifeStab", "Stab" },
        { "KnifeStab2", "Stab" },
        { "Laugh1", "Laughing" },
        { "Laugh1_0", "Laughing" },
        { "Laugh2", "Laughing" },
        { "Leap1", "Chitters" },
        { "Leap2", "Chitters" },
        { "LeapScreamV2", "Maneater shrieks" },
        { "LightningAudio", "Upbeat music plays" },
        { "LightningStrike1", "Lightning strikes" },
        { "LightningStrike2", "Lightning strikes" },
        { "LightningStrike3", "Lightning strikes" },
        { "LightningStrike4", "Lightning strikes" },
        { "LongRoar1", "Creature roars" },
        { "LongRoar2", "Creature roars" },
        { "LongRoar3", "Creature roars" },
        { "LoudCreak1", "Loud creaks" },
        { "LoudCreak2", "Loud creaks" },
        { "LoudCreak3", "Loud creaks" },
        { "LRADAlarm3", "Blaring siren" },
        { "LradBrainwashingSignal1", "Blaring alarm" },
        { "LradBrainwashingSignal4", "Brainwashing signal" },
        { "LradBrainwashingSignal6", "Broadcasted crying" },
        { "LradBrainwashingSignal7", "Broadcasted crying" },
        { "LradBrainwashingSignal8", "Broadcasted whining" },
        { "Lunge1", "Dog lunges" },
        { "LungMachine", "Apparatus hums" },
        { "LungMachineDisconnect", "Apparatus disconnects" },
        { "MaskAttackPlayer", "Distorted laughter" },
        { "MaskComedyAttach", "Mask attaches itself to player" },
        { "MaskCry1", "Mask cries" },
        { "MaskCry2", "Mask cries" },
        { "MaskCry3", "Mask cries" },
        { "MaskCry4", "Mask cries" },
        { "MaskLaugh1", "Mask laughs" },
        { "MaskLaugh2", "Mask laughs" },
        { "MaskLaugh3", "Mask laughs" },
        { "MaskPuke", "Masked vomits" },
        { "MetalDoorShut1 1", "Door shuts" },
        { "MetalDoorShut1", "Door shuts" },
        { "MetalDoorShut2", "Door shuts" },
        { "MeteorApproachingA", "Meteor crackles distantly" },
        { "MeteorApproachingB", "Meteor crackles distantly" },
        { "MeteorApproachingC", "Meteor crackles distantly" },
        { "MeteorLandClose", "Meteor crashes" },
        { "MeteorLandFar", "Distant meteor crash" },
        { "MeteorScream1", "Meteor shrieks" },
        { "MineBeep", "Landmine beeps" },
        { "MineDetonate", "Landmine detonates" },
        { "MineDetonateDistance", "Landmine detonates distantly" },
        { "MineshaftElevatorStartDownward", "Elevator activates" },
        { "MineshaftElevatorStartUpward", "Elevator activates" },
        { "MineshaftElevatorTravel", "Elevator hums" },
        { "MineTrigger", "Landmine triggers" },
        { "MissileExplosion", "Missile explodes" },
        { "MissileExplosion2", "Missile explodes" },
        { "MissileFly", "Missile shrieks" },
        { "monsterNoise", "Monster noises" },
        { "monsterNoise2", "Monster noises" },
        { "monsterNoiseB", "Monster noises" },
        { "MoveThroughWater", "Water shifting" },
        { "Nervous", "Creature nervous" },
        { "NutcrackerAngry", "Nutcracker marching" },
        { "PlushieSqueeze", "Plushie squeaks" },
        { "PurchaseSFX", "Bell rings" },
        { "Pop1", "Jester pops" },
        { "PuffSFX", "Spores burst" },
        { "PullCord", "Cord pulled" },
        { "RadarBoosterFlash", "Click" },
        { "Radio1", "Radio plays" },
        { "Radio_Bananas", "Radio plays" },
        { "Radio_Interference", "Radio static" },
        { "Radio_ParadeOfTheWoodenSoldiers", "Radio plays" },
        { "Radio_SomeSunnyDay", "Radio plays" },
        { "Radio_WestIndiesBlues", "Radio plays" },
        { "RadMechAmbientSFX", "Idle beeping" },
        { "RadMechStomp1", "Stomps" },
        { "RadMechStomp2", "Stomps" },
        { "RadMechStomp3", "Stomps" },
        { "RadMechStomp4", "Stomps" },
        { "RadMechWake", "Engine starts" },
        { "RattleTail", "Rattling tail" },
        { "RecordPlayerJazz", "Record plays" },
        { "RecordScratch1", "Record scratches" },
        { "RecordScratch2", "Record scratches" },
        { "RevEngine1", "Engine stalling" },
        { "Roar", "Giant rumbles" },
        { "Roar_0", "Dog roars" },
        { "RobotToyCheer", "Robot toy cheers" },
        { "robotTune", "Electronic music" },
        { "SandWormRoar", "Earth Leviathan roars" },
        { "SandWormRoar2", "Earth Leviathan roars" },
        { "Scan", "Scan activates" },
        { "ScissorsSnip", "Scissors snip" },
        { "Scream1", "Low screaming" },
        { "ShakeEmptyCan", "Empty can rattles" },
        { "ShakeSpraycan", "Spraypaint can rattles" },
        { "ShakeSpraycanFull1", "Spraypaint can rattles" },
        { "ShakeSpraycanFull2", "Spraypaint can rattles" },
        { "ShakeSpraycanFull3", "Spraypaint can rattles" },
        { "ShakeSpraycanFull4", "Spraypaint can rattles" },
        { "ShiftToDrive", "Shifts" },
        { "ShiftToPark", "Shifts" },
        { "ShiftToReverse", "Shifts" },
        { "ShipAlarmHornConstant", "Ship horn blares" },
        { "ShipAlarmHornConstantDistant", "Ship horn blares distantly" },
        { "ShipArriveAtPlanet", "Ship lands" },
        { "ShipDoorOpenPressurize", "Ship lands" },
        { "ShipTeleporterBeam", "Teleports" },
        { "ShipTeleporterSpin", "Teleporter activates" },
        { "ShipTeleporterSpinInverse", "Inverse Teleporter activates" },
        { "ShipThrusterAmbiance", "Ship thruster" },
        { "ShipThrusterClose", "Ship thruster" },
        { "ShortRoar1", "Short roars" },
        { "ShotgunBlast", "Shotgun shoots" },
        { "ShotgunBlast2", "Shotgun shoots" },
        { "ShotgunReload", "Shotgun reloads" },
        { "ShotgunReloadNutcracker", "Nutcracker reloads" },
        { "ShovelHitDefault", "Shovel thuds" },
        { "ShovelHitDefault2", "Shovel thuds" },
        { "ShowerOn", "Shower sprinkling" },
        { "Shriek1", "Shriek" },
        { "Shriek2", "Shriek" },
        { "SkipWalk", "Skipping" },
        { "SkipWalk1", "Skipping" },
        { "SkipWalk2", "Skipping" },
        { "SkipWalk3", "Skipping" },
        { "SkipWalk4", "Skipping" },
        { "SkipWalk5", "Skipping" },
        { "SkipWalk6", "Skipping" },
        { "SlimeAngry", "Slime charges" },
        { "SlimeDance", "Slime dances" },
        { "SlimeIdle", "Slime bubbles" },
        { "SlimeKillPlayer", "Player is absorbed" },
        { "SnareBuildup", "Drumroll" },
        { "SoccerBallKick1", "Bounces" },
        { "SoccerBallKick2", "Bounces" },
        { "SoccerBallKick3", "Bounces" },
        { "SpikeRoofSlam", "Heavy slam" },
        { "SpikeRoofTrapCreak", "Metal shrieking" },
        { "SpraySpraycan", "Hissing" },
        { "Spring1", "Spring chimes" },
        { "Spring2", "Spring chimes" },
        { "Spring3", "Spring chimes" },
        { "SpringWobble1", "Spring wobbles" },
        { "SpringWobble2", "Spring wobbles" },
        { "Squeak1", "Squeaks" },
        { "Squeak2", "Squeaks" },
        { "StartChargeForward", "Thruster roars" },
        { "StartGameLever", "Lever is pulled" },
        { "StickyNote", "Paper rustling" },
        { "Stomp", "Stomps" },
        { "Stomp1", "Thump" },
        { "Stomp1double", "Double Stomps" },
        { "Stomp2", "Thump" },
        { "Stomp2double", "Double Stomps" },
        { "Stomp3", "Thump" },
        { "StopTurning1", "Click" },
        { "StopTurning2", "Click" },
        { "StopTurning3", "Click" },
        { "Stomp3double", "Double stomps" },
        { "StormStaticElectricity", "Static electricity buzzing" },
        { "StuckInWeb", "Web rustling" },
        { "StunCrawler", "Thumper stunned" },
        { "StunDog", "Dog stunned" },
        { "StunDoublewing", "Bird stunned" },
        { "StunFlowerman", "Bracken stunned" },
        { "StunGiant", "Giant stunned" },
        { "StunSpider", "Spider stunned" },
        { "TerminalTypoError", "Error beep" },
        { "Thunder1", "Thunder" },
        { "Thunder2", "Thunder" },
        { "Thunder3", "Thunder" },
        { "thunder_normal_8", "Thunder" },
        { "ToiletFlush", "Toilet flushes" },
        { "Transformation", "Crackling cries" },
        { "TunnelIntoGround1", "Earth Leviathan lands" },
        { "TurnCrank1", "Cranking" },
        { "TurnCrank2", "Cranking" },
        { "TurnCrank3", "Cranking" },
        { "TurnTVOff", "TV turns off" },
        { "TurnTVOn", "TV turns on" },
        { "TurretActivate", "Turret activates" },
        { "TurretBerserkMode", "Turret berserks" },
        { "TurretDeactivate", "Turret deactivates" },
        { "TurretFire", "Turret fires" },
        { "TurretFireDistance", "Turret fires distantly" },
        { "TurretSeePlayer", "Turret locks aim" },
        { "TurretWallHits", "Bullets ricochet" },
        { "TVKittenTheme", "Muffled trombone music" },
        { "VentCrawl1", "Vent noises" },
        { "VentOpen1", "Vent opens" },
        { "WarningHUD", "Warning beep" },
        { "WarningHUD2", "Warning beep" },
        { "WarningHUD3", "Warning beep" },
        { "WeatherWarningPSA", "Weather alert" },
        { "WindshieldShatter", "Crackling" },
    };

    public Dictionary<string, List<(float, string)>> DialogueTranslations => new(StringComparer.OrdinalIgnoreCase)
    {
        {
            "0DaysLeftAlert",
            new()
            {
                (0, "[Company Jingle plays]"),
                (4.969f, "Report to the company building immediately"),
                (7.189f, "to sell your scrap metal and other goods."),
                (9.758f, "You have zero days left to meet the profit quota."),
                (13.085f, "You can use the terminal to route"),
                (14.874f, "the autopilot to the company building."),
            }
        },
        {
            "IntroCompanySpeech",
            new()
            {
                (0, "[Company Jingle plays]"),
                (7.310f, "Welcome to your first day on the job!"),
                (10.140f, "This is your very own autopilot ship"),
                (12.440f, "where you will eat and sleep"),
                (13.800f, "for the duration of your contract."),
                (15.280f, "[Unintelligible fast speech]"),
                (19.940f, "Make yourself at home."),
                (21.690f, "To complete the onboarding process,"),
                (23.770f, "you will want to check the instruction manual"),
                (25.650f, "and sign into your ship's computer terminal."),
                (28.290f, "We trust you will be a great asset to the company."),
                (31.035f, "Great-great asset to the company-"),
                (32.830f, "asset great-great-great asset to the company-"),
                (35.235f, "asset to great-great asset to the-"),
            }
        },
        {
            "LightningAudio",
            new()
            {
                (0.0f, "[Upbeat music plays]"),
                (3.020f, "[Lightning strikes]"),
                (4.300f, "[Laugh track]"),
            }
        },
        {
            "SnareFleaTipChannel",
            new()
            {
                (0.330f, "If an entity has come in contact with a crew member,"),
                (2.830f, "please refrain from immediate self-defense."),
                (5.300f, "Instead, ask the crew member the following:"),
                (7.495f, "\"Is the entity being aggressive?\""),
                (9.410f, "\"Are you injured?\""),
                (10.635f, "\"Do you need assistance?\""),
                (11.730f, "If the answer to all of these questions is yes,"),
                (13.920f, "you begin your self-defense measures."),
                (15.900f, "If the crew member is stressed,"),
                (17.190f, "strike a question like \"How was your day?\""),
                (19.620f, "Thank you for your cooperation, and happy travels!"),
            }
        },
        {
            "VoiceHey",
            new()
            {
                (0.0f, "Hey."),
            }
        },
    };
}