# Handoff

## Project

rakugaking

## Current Status

ADeL Discovery, Bootstrap, and Design phases are complete.

Implementation Phase has started.

Sprint 1 initial implementation has been added to the repository.

## Current Phase

- Phase: Implementation
- Status: Sprint 1 Initial Implementation Added

## Completed

- Project Discovery completed
- Project type selected
- Minimum MVP Set selected
- Initial project docs created
- First playable MVP scope decided
- Drawing method decided for first MVP
- Humanoid-only first body type decided
- Command system direction decided for later phases
- Battle rules decided
- Unity implementation structure drafted
- Scene flow defined
- UI wireframes defined
- Drawing-to-physics rules drafted
- Balance direction drafted
- Phase 1 implementation plan created
- Unity minimum project files added
- Sprint 1 battle scripts added
- Sprint 1 scene/prefab builder added

## Confirmed Decisions

- Project name: rakugaking
- Engine: Unity
- Target platforms: smartphone and PC
- Target users: children and adults
- Core idea: draw 3D characters, assign simple commands, and battle automatically
- Programming must be easy and command-based
- First playable MVP is local-first
- First implementation starts with placeholder physics battle before drawing
- First drawing approach is 2D drawing applied to simple 3D physics parts
- First body type is humanoid only
- Battle uses HP, ring out, and time limit
- Online battle remains a future product goal but is not implemented now
- Character sharing is postponed
- Monetization remains a future product goal but is not implemented now

## Explicitly Not Implemented Now

- Drawing features
- Drawing-to-physics conversion
- Command system
- Online battle
- Payment / shop systems
- Multiple character species/body types
- Character sharing
- Public character gallery
- Share codes
- User-facing export/import
- Full UI

## Important Product Direction

The game should be funny because characters do not move perfectly.

The drawing shape should affect battle behavior.

The player should not need to write code.

## Current Implementation Files

- `.gitignore`
- `Packages/manifest.json`
- `ProjectSettings/ProjectVersion.txt`
- `Assets/Rakugaking/README.md`
- `Assets/Rakugaking/Scripts/Battle/BattleResult.cs`
- `Assets/Rakugaking/Scripts/Battle/BattleController.cs`
- `Assets/Rakugaking/Scripts/Battle/BattleTimer.cs`
- `Assets/Rakugaking/Scripts/Battle/RingOutDetector.cs`
- `Assets/Rakugaking/Scripts/Battle/Sprint1AutoBattleMotion.cs`
- `Assets/Rakugaking/Scripts/Battle/Sprint1CollisionDamage.cs`
- `Assets/Rakugaking/Scripts/Character/Health.cs`
- `Assets/Rakugaking/Scripts/Character/BattleCharacter.cs`
- `Assets/Rakugaking/Scripts/UI/BattleHud.cs`
- `Assets/Rakugaking/Scripts/Editor/Sprint1PrototypeBattleBuilder.cs`
- `docs/SPRINT_1_STATUS.md`

## Current Implementation Entry Point

Open the project in Unity and run:

```txt
Unity Menu > Rakugaking > Sprint 1 > Build Prototype Battle Scene
```

This generates:

- `Assets/Rakugaking/Scenes/PrototypeBattle.unity`
- `Assets/Rakugaking/Prefabs/Character/PlaceholderFighter.prefab`
- `Assets/Rakugaking/Prefabs/Battle/Arena.prefab`

## Current Implementation Goal

Create a Unity prototype where two placeholder humanoid fighters automatically battle in a simple arena and produce a result.

## Remaining Unknowns

- whether the generated Unity scene compiles and runs without adjustment
- physics tuning values
- exact strength of drawing size/shape effects
- future networking solution
- final monetization model
- local vs cloud save timing

## Instruction for Next AI

Do not start with online, monetization, multiple species, drawing features, drawing-to-physics conversion, command system, or full UI.

First verify Sprint 1 in Unity.
