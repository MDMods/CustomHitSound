# CustomHitSound

Allows you to use custom hit sounds in game.

[中文Readme](README.zh.md)

## How to Install
Install [Muse Dash Mod tools](https://github.com/MDModsDev/MuseDashModToolsUI/releases/latest), follow the instructions and install the mod.

Then, download BattleSfx.zip from [Releases](https://github.com/MDModsDev/CustomHitSound/releases/latest), extract it into `Muse Dash\UserData` folder.

The path should be `Muse Dash\UserData\BattleSfx`.

## How to use the Hit Sound Pack
There should be in game toggles in the Audio Setting, under the Hit Sound Effects

![Screenshot](Intro/Screenshot.png)

Select the toggle to use the sound effect.

## How to Create your own Hit Sound
**There is a default template in BattleSfx.zip (The Celeste folder).**

### There are several hit sounds you can replace:

```
char_common_fever
char_common_empty_atk
char_common_empty_jump
sfx_hp
sfx_score
sfx_press_top
sfx_press
sfx_jump
sfx_mezzo_1
sfx_forte_2
sfx_piano_2
sfx_forte_3
sfx_mezzo_3
sfx_ghost_gc
hitsound_000
hitsound_001
hitsound_002
hitsound_003
hitsound_004
hitsound_005
hitsound_006
hitsound_007
hitsound_008
hitsound_009
hitsound_010
hitsound_011
hitsound_012
hitsound_013
hitsound_014
hitsound_015
```

### And for the battle sound names, you can refer to the following table:

```
sfx_forte_2 = large2, boss rush
sfx_forte_3 = hammer
sfx_mezzo_1 = small, medium, gemini, boss note
sfx_mezzo_3 = ghost
sfx_piano_2 = large1, raider
sfx_hp = heart
sfx_score = blue collectable note
sfx_press_top = hold start/end
sfx_press = holding sound
sfx_ghost_gc = gc scene ghost
hitsound = masher 
```

### And also the character hurt sound

#### For Marija:
```
VoiceMarijaHurt02
VoiceMarijaHurt03
VoiceMarijaHurt04
VoiceMarijaHurt05
VoiceMarijaHurt06
VoiceMarijaHurt07
VoiceMarijaHurt08
VoiceMarijaHurt09
```

#### For Rin:
```
VoiceRinHurt01
VoiceRinHurt02
VoiceRinHurt03
VoiceRinHurt06
VoiceRinHurt09
VoiceRinHurt10
VoiceRinHurt11
```

#### For Buro:
```
VoiceBuroHurt01
VoiceBuroHurt03
VoiceBuroHurt05
VoiceBuroHurt06
VoiceBuroHurt07
VoiceBuroHurt08
VoiceBuroHurt10
```

#### For Ola:
```
VoiceOlaHurt01
VoiceOlaHurt02
VoiceOlaHurt03
VoiceOlaHurt04
VoiceOlaHurt05
```

#### For Yume:
```
VoiceYumeHurt01
VoiceYumeHurt02
VoiceYumeHurt03
VoiceYumeHurt04
VoiceYumeHurt05
VoiceYumeHurt06
VoiceYumeHurt07
```

#### For Neko:
```
VoiceNekoHurt01
VoiceNekoHurt02
VoiceNekoHurt03
VoiceNekoHurt04
VoiceNekoHurt05
```

#### For Reimu:
```
VoiceReimuHurt01
VoiceReimuHurt02
VoiceReimuHurt03
VoiceReimuHurt04
VoiceReimuHurt05
```

#### For El_Clear:
```
VoiceClearHurt02
VoiceClearHurt04
VoiceClearHurt06
VoiceClearHurt07
VoiceClearHurt08
VoiceClearHurt10
```

#### For Marisa:
```
VoiceMarisaHurt01
VoiceMarisaHurt02
VoiceMarisaHurt03
VoiceMarisaHurt04
VoiceMarisaHurt05
```

#### For Amiya:
```
VoiceAmiyaHurt01
VoiceAmiyaHurt02
VoiceAmiyaHurt03
VoiceAmiyaHurt04
VoiceAmiyaHurt05
```

### For naming style

**You should name the audio file with the following format:**

**soundname_<folder name in lowercase>.wav (or mp3, aiff, ogg)**

For example: sfx_forte_2_celeste.wav in Celeste folder.

### The game will use the default sound if you don't implement the sound.

### Ps

**If you want to add your sound pack into default release, contact me on discord.**