# Minimum Implementation Plan

## Purpose

Define the smallest Unity implementation plan for rakugaking MVP.

This plan starts Implementation Phase without building future systems too early.

## Current Phase

- Phase: Implementation
- Status: Started

## Main Goal

Create the smallest playable Unity prototype where two placeholder humanoid fighters automatically battle in a simple arena and produce a result.

## Explicitly Out of Scope

Do not implement these yet:

- online battle
- monetization / payment / shop
- multiple character species or body types
- character sharing
- public gallery
- share codes
- user-facing export/import
- full drawing editor
- polished art
- ranked mode
- matchmaking

## Implementation Principle

Prototype the battle first.

Do not start with the drawing editor.

Reason:

If the automatic physics battle is not funny and readable with placeholder fighters, drawing will not fix the core game.

## Phase 0: Unity Project Setup

### Goal

Prepare a clean Unity project structure.

### Tasks

1. Create or confirm Unity project.
2. Create folder structure:

```txt
Assets/Rakugaking/
  Scenes/
  Scripts/
    Core/
    Battle/
    Character/
    Commands/
    UI/
  Prefabs/
    Battle/
    Character/
    UI/
  Materials/
  Tests/
```

3. Create `PrototypeBattle.unity`.

### Acceptance Criteria

- Unity project opens.
- Folder structure exists.
- PrototypeBattle scene exists.

## Phase 1: Prototype Arena

### Goal

Create a simple battle space.

### Tasks

1. Add flat platform.
2. Add ring-out boundary.
3. Add camera.
4. Add basic lighting.

### Acceptance Criteria

- Arena is visible.
- Characters can fall off the platform.
- Camera can see both fighters.

## Phase 2: Placeholder Fighter

### Goal

Create a simple humanoid physics fighter.

### Tasks

1. Create placeholder body parts using primitive shapes.
2. Add Rigidbody components.
3. Add simple colliders.
4. Add joints if needed.
5. Create `PlaceholderFighter` prefab.

### Minimum Parts

- body
- head
- left arm
- right arm
- left leg
- right leg

### Acceptance Criteria

- Fighter spawns in scene.
- Fighter can be affected by physics.
- Fighter does not instantly break the scene.

## Phase 3: Command System Prototype

### Goal

Make fighters act automatically.

### Tasks

1. Create command enum.
2. Create command assignment model.
3. Create command runner.
4. Implement first commands:
   - punch
   - swing
   - kick
5. Repeat commands automatically.

### Acceptance Criteria

- Fighter performs repeated actions.
- Player does not directly control the fighter.
- Commands are simple and readable.

## Phase 4: Battle Rules

### Goal

Make the battle start, progress, and end.

### Tasks

1. Create BattleController.
2. Spawn two fighters.
3. Add HP.
4. Add timer.
5. Add ring-out detection.
6. Add simple hit detection.
7. Add result evaluation.

### Rules

- HP starts at 100.
- Timer starts at 60 seconds.
- Ring-out is instant loss.
- Time-up winner is higher HP.
- Equal HP is draw.

### Acceptance Criteria

- Two fighters battle automatically.
- HP can decrease.
- Ring-out can end battle.
- Timer can end battle.
- Result is determined.

## Phase 5: Minimal UI

### Goal

Show enough information to test the battle.

### Tasks

1. Show Fighter A HP.
2. Show Fighter B HP.
3. Show timer.
4. Show result text.
5. Add restart button if simple.

### Acceptance Criteria

- Tester can understand battle status.
- Tester can see who won and why.

## Phase 6: Review and Update Specs

### Goal

Use prototype results to improve the design.

### Tasks

1. Test whether battle is funny.
2. Test whether commands are readable.
3. Test whether physics is too broken or too stiff.
4. Update docs based on findings.

### Acceptance Criteria

- Known issues are documented.
- Balance notes are updated.
- Next implementation phase is clear.

## First Success Definition

Implementation Phase 1 succeeds when:

- `PrototypeBattle.unity` runs.
- Two placeholder fighters spawn.
- They execute commands automatically.
- The battle can end by HP, timer, or ring-out.
- The result is displayed.
- No online, payment, sharing, multiple species, or full drawing editor has been added.

## Next Phase After Success

After this minimum prototype works, the next phase may add:

1. simple part drawing prototype
2. drawing-to-physics calculator
3. applying drawing to placeholder parts
4. local character save/load

Do not jump directly to online or monetization.
