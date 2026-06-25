# Scene Flow Spec

## Purpose

Define the Unity scene structure and screen flow for rakugaking.

This document helps implementation start without guessing the first scene order.

## First Playable MVP Scene Strategy

Use a small number of scenes first.

Avoid creating many separate scenes before the core loop works.

## Recommended Scenes

```txt
Assets/Rakugaking/Scenes/Boot.unity
Assets/Rakugaking/Scenes/Home.unity
Assets/Rakugaking/Scenes/CharacterCreate.unity
Assets/Rakugaking/Scenes/CommandSetup.unity
Assets/Rakugaking/Scenes/Battle.unity
Assets/Rakugaking/Scenes/Result.unity
```

## Phase 1 Prototype Scene

Before full scene flow is implemented, Phase 1 may use only:

```txt
Assets/Rakugaking/Scenes/PrototypeBattle.unity
```

This scene proves automatic physics battle with placeholder characters.

## Main Flow

```txt
Boot
↓
Home
↓
CharacterCreate
↓
CommandSetup
↓
Battle
↓
Result
↓
Home / CommandSetup / CharacterCreate
```

## Scene Details

## Boot

Purpose:

- initialize game systems
- load saved data
- route to Home

Required later, but can be skipped in the first prototype.

## Home

Purpose:

- start character creation
- choose saved character
- start battle
- access future online mode

MVP buttons:

- Create Character
- Local Battle
- Settings

Future buttons:

- Online Battle
- Shop

## CharacterCreate

Purpose:

- draw character body parts
- preview character assembly
- save character

Flow:

1. choose body part
2. draw part
3. confirm part
4. repeat until complete
5. preview character
6. continue to CommandSetup

## CommandSetup

Purpose:

- assign simple commands to arms, legs, and body

MVP UI:

- part selector
- command cards
- strength/speed presets if needed
- start battle button

## Battle

Purpose:

- run automatic battle
- display HP, timer, and result trigger

MVP UI:

- character A HP
- character B HP
- timer
- pause button if needed

## Result

Purpose:

- show winner/draw
- show reason
- allow rematch or edit

Buttons:

- Rematch
- Edit Commands
- Edit Character
- Home

## Navigation Rules

- Player should never be trapped.
- Back navigation should be simple.
- Battle should not require direct control.
- Result should always offer a clear next action.

## First Implementation Recommendation

Do not build all scenes at once.

First build `PrototypeBattle.unity`.

After the battle prototype works, build:

1. Home
2. CharacterCreate
3. CommandSetup
4. Battle
5. Result

## Related Docs

- `docs/IMPLEMENTATION_PHASE_1.md`
- `docs/UI_UX_SPEC.md`
- `docs/BATTLE_SPEC.md`
