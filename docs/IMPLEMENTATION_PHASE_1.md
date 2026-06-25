# Implementation Phase 1 Plan

## Phase Name

Physics Battle Prototype

## Purpose

Build the smallest Unity prototype that proves automatic physics battle is fun and readable.

This phase does not include the final drawing system.

## Goal

Two placeholder humanoid fighters automatically battle in a simple arena and produce a result.

## Scene

Create:

```txt
Assets/Rakugaking/Scenes/PrototypeBattle.unity
```

## Required Prefabs

```txt
Assets/Rakugaking/Prefabs/Battle/Arena.prefab
Assets/Rakugaking/Prefabs/Character/PlaceholderFighter.prefab
Assets/Rakugaking/Prefabs/UI/BattleHud.prefab
```

## Required Script Areas

```txt
Assets/Rakugaking/Scripts/Core/
Assets/Rakugaking/Scripts/Battle/
Assets/Rakugaking/Scripts/Character/
Assets/Rakugaking/Scripts/Commands/
Assets/Rakugaking/Scripts/UI/
```

## Minimum Scripts

### Battle

- BattleController.cs
- BattleTimer.cs
- BattleResult.cs
- BattleResultEvaluator.cs
- RingOutDetector.cs
- HitDetector.cs

### Character

- BattleCharacter.cs
- PlaceholderFighterBuilder.cs
- FighterStats.cs

### Commands

- CommandType.cs
- CommandAssignment.cs
- CommandRunner.cs
- ICommand.cs
- PunchCommand.cs
- SwingCommand.cs
- KickCommand.cs

### UI

- BattleHudView.cs
- ResultView.cs

## Battle Rules

- 1 vs 1
- 60 second time limit
- HP-based damage
- ring out loss
- draw if HP is equal when time ends

## Placeholder Fighter Requirements

A placeholder fighter should have:

- body
- head
- two arms
- two legs
- simple colliders
- Rigidbody components
- basic joints

The fighter does not need final art.

## First Commands

Implement only these first:

- punch
- swing
- kick

Guard, jump, and crouch can come after the prototype battle works.

## Success Criteria

Phase 1 is complete when:

- scene opens in Unity
- two fighters spawn
- both execute commands repeatedly
- contact can reduce HP
- ring out can end the battle
- timer can end the battle
- result is shown
- battle looks messy but readable

## Not Allowed in Phase 1

- online battle
- drawing UI
- save/load
- monetization
- multiple body types
- polished art
- complex AI

## Notes for AI Implementer

Keep code simple.

Prefer readable C# classes over clever architecture.

Do not add packages unless necessary.

Do not optimize before the prototype works.
