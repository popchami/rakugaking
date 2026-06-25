# Architecture

## Technology Stack

- Engine: Unity
- Target Platforms: Smartphone and PC
- Language: C#

## Architecture Principle

Build the game in stages.

Do not start with complex online systems before the core drawing-to-battle loop works.

However, do not design the project in a way that blocks online battle or monetization later.

Character sharing is postponed and should not drive early architecture.

## First Implementation Architecture

The first implementation should be a local playable prototype.

It should prove this loop:

Draw → Assemble → Command → Battle → Result

## Recommended Unity Folder Structure

```txt
Assets/
  Rakugaking/
    Scenes/
    Scripts/
      Core/
      Drawing/
      Character/
      Commands/
      Battle/
      SaveData/
      UI/
      Shared/
    Prefabs/
      Character/
      Battle/
      UI/
    ScriptableObjects/
      Commands/
      BodyParts/
    Materials/
    Textures/
    Tests/
```

## Runtime Modules

## 1. Core Module

Responsibilities:

- application state
- scene flow
- common interfaces
- shared constants

Suggested classes:

- GameFlowController
- SceneRoute
- ProjectConstants

## 2. Drawing Module

Responsibilities:

- capture player drawing input
- store drawing data
- generate part textures or simple part shapes
- calculate drawing-to-physics values
- provide part preview

Suggested classes:

- DrawingCanvasController
- DrawingInputHandler
- PartDrawingData
- PartTextureGenerator
- DrawingPhysicsCalculator
- DrawingPhysicsValues

## 3. Character Module

Responsibilities:

- manage character data
- connect parts
- create a physics-based character
- prepare character for battle

Suggested classes:

- CharacterData
- CharacterPartData
- CharacterAssembler
- PhysicsPartBuilder
- CharacterPreviewController

## 4. Command Module

Responsibilities:

- define simple commands
- assign commands to parts
- execute commands repeatedly during battle

Suggested classes:

- CommandDefinition
- CommandAssignment
- CommandRunner
- PunchCommand
- SwingCommand
- GuardCommand
- KickCommand
- JumpCommand
- CrouchCommand

## 5. Battle Module

Responsibilities:

- spawn characters
- run automatic battle
- manage HP, timer, and ring out
- evaluate win/loss/draw

Suggested classes:

- BattleController
- BattleCharacter
- BattleTimer
- BattleResultEvaluator
- HitDetector
- RingOutDetector

## 6. Save Data Module

Responsibilities:

- save characters locally
- load characters locally
- serialize character data for internal use

Suggested classes:

- CharacterSaveService
- CharacterSaveData
- SaveDataRepository
- CharacterSerializer

## 7. UI Module

Responsibilities:

- home screen
- drawing screen
- command setup screen
- battle HUD
- result screen

Suggested classes:

- HomeView
- DrawingView
- CommandSetupView
- BattleHudView
- ResultView

## 8. Online Battle Module

Status:

- future phase

Responsibilities for future phases:

- create or join private rooms
- match players
- transfer selected character data temporarily inside a battle session
- synchronize commands or battle state
- handle disconnects

Not responsibilities:

- public character gallery
- share codes
- permanent character uploads
- browsing other players' characters

## 9. Monetization Module

Status:

- future phase

Responsibilities for future phases:

- manage owned content
- unlock cosmetics or slots
- integrate store systems

Monetization must not affect battle strength directly.

## Suggested Development Order

1. Unity project setup
2. scene flow skeleton
3. simple battle arena
4. placeholder physics humanoid
5. command execution prototype
6. battle result logic
7. drawing input prototype
8. drawing-to-physics calculator
9. drawing-to-part visual application
10. character assembly from drawn parts
11. local save/load
12. character vs saved character battle
13. online battle design refinement
14. monetization design refinement

## Design Risks

### Drawing to 3D Conversion

This is the largest technical risk.

First MVP decision:

- use 2D drawing applied to simple 3D physics parts
- do not start with freeform 3D sculpting

### Physics Stability

The game needs messy movement, but not broken movement.

Characters should fail in funny ways, not in unreadable ways.

### Online Battle

Real-time physics synchronization can be difficult.

Possible safer options:

- host-authoritative simulation
- input/command synchronization
- temporary character data transfer inside the match

## Current Recommendation

For first playable MVP, prefer:

- local-first battle
- simple humanoid skeleton
- drawn textures or simple generated shapes
- drawing-to-physics values
- command buttons rather than visual scripting
