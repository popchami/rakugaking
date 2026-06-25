# Implementation Ready Checklist

## Purpose

This checklist defines what must be true before rakugaking moves from Design to Implementation.

## Current Recommendation

The project is nearly ready for the first Unity implementation phase.

Implementation should start with a prototype, not the full game.

## Required Docs

- [x] PROJECT_STATE.md
- [x] PROJECT_OVERVIEW.md
- [x] MVP_SPEC.md
- [x] FEATURE_SPEC.md
- [x] DATA_SPEC.md
- [x] UI_UX_SPEC.md
- [x] ARCHITECTURE.md
- [x] AI_RULES.md
- [x] TEST_PLAN.md
- [x] HANDOFF.md
- [x] DESIGN_DECISIONS.md
- [x] CHARACTER_SPEC.md
- [x] DRAWING_SPEC.md
- [x] COMMAND_SPEC.md
- [x] BATTLE_SPEC.md

## First Implementation Goal

Create a Unity prototype that proves the battle loop with placeholder visuals before full drawing is implemented.

## First Implementation Scope

### Included

- Unity project structure
- basic scene flow
- simple arena
- placeholder humanoid physics character
- simple command execution
- automatic battle
- HP / timer / ring out result

### Not Included Yet

- full drawing tool
- character sharing server
- real-time online battle
- payment implementation
- multiple body types
- advanced visual scripting

## Why Placeholder First

Before building the drawing tool, the project must prove that a physics character can move, attack, fall, and produce funny readable battles.

If the battle is not fun with placeholders, drawing will not fix it.

## Phase 1 Implementation Tasks

1. Create Unity project folders.
2. Create first test scene.
3. Create flat arena.
4. Create placeholder humanoid fighter prefab.
5. Add simple physics parts and joints.
6. Add command runner.
7. Implement punch / swing / kick as first commands.
8. Add HP and hit detection.
9. Add ring out detection.
10. Add timer.
11. Add result screen or result log.

## Phase 1 Acceptance Criteria

- Two placeholder fighters spawn.
- Fighters execute commands automatically.
- Fighters can hit each other.
- Fighters can fall or ring out.
- Battle ends with win/loss/draw.
- The result is visible.
- The behavior is messy but understandable.

## Phase 2 Implementation Tasks

After Phase 1 passes:

1. Add drawing canvas prototype.
2. Draw one body part.
3. Apply drawing to a placeholder 3D part.
4. Save drawing data.
5. Assemble a simple drawn character.
6. Use drawn character in battle.

## AI Instruction

Do not implement everything at once.

Start with the smallest playable physics battle prototype.
