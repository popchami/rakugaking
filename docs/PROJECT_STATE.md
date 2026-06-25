# Project State

## Project

- Name: rakugaking
- Repository: popchami/rakugaking
- Library: ADeL / AI Development Library

## Current Phase

- Phase: Implementation
- Phase Status: Started
- Discovery Status: Complete
- Bootstrap Status: Complete
- Design Status: Complete

## Confirmed Information

### Project Idea

rakugaking is a 3D drawing battle game where players draw character parts, assign simple behavior commands, and watch the characters fight automatically.

### Target Users

Children and adults.

### MVP Success Condition

A player can battle using a character they drew.

### Target Platform

- Smartphone
- PC

### Technology Stack

- Unity

### Design Principle

Programming must not be difficult. The player should choose simple commands rather than write code.

## Project Type Selection

- Primary Type: Game
- Secondary Considerations:
  - Online battle
  - Monetization

## Postponed Product Areas

Do not implement these during the current MVP implementation phase:

- Online battle
- Character sharing
- Public character gallery
- Share codes
- User-facing export/import
- Monetization / payment implementation
- Multiple character species/body types
- Full drawing editor

Temporary internal data structures may still consider future online battle, but no online implementation should be built now.

## Completed Design Documents

- README.md
- docs/00_START_HERE.md
- docs/PROJECT_OVERVIEW.md
- docs/MVP_SPEC.md
- docs/FEATURE_SPEC.md
- docs/DATA_SPEC.md
- docs/UI_UX_SPEC.md
- docs/ARCHITECTURE.md
- docs/AI_RULES.md
- docs/TEST_PLAN.md
- docs/HANDOFF.md
- docs/DESIGN_DECISIONS.md
- docs/CHARACTER_SPEC.md
- docs/DRAWING_SPEC.md
- docs/DRAWING_TO_PHYSICS_SPEC.md
- docs/COMMAND_SPEC.md
- docs/BATTLE_SPEC.md
- docs/BALANCE_SPEC.md
- docs/ONLINE_SPEC.md
- docs/MONETIZATION_SPEC.md
- docs/SCENE_FLOW_SPEC.md
- docs/UI_WIREFRAME_SPEC.md
- docs/ASSET_SPEC.md
- docs/IMPLEMENTATION_READY_CHECKLIST.md
- docs/IMPLEMENTATION_PHASE_1.md

## Implementation Entry Point

Start with:

- `docs/MINIMUM_IMPLEMENTATION_PLAN.md`

Then use:

- `docs/IMPLEMENTATION_PHASE_1.md`

## Current Implementation Scope

Build the smallest Unity MVP prototype:

1. Unity project/folder setup.
2. Prototype battle scene.
3. Placeholder humanoid fighters.
4. Simple automatic commands.
5. HP, timer, ring out.
6. Battle result.

## Do Not Do Yet

- Do not implement online battle.
- Do not implement payment or shop systems.
- Do not implement multiple character species.
- Do not implement public character sharing.
- Do not implement a full drawing editor.
- Do not overbuild architecture before the battle prototype works.
