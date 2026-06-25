# Project State

## Project

- Name: rakugaking
- Repository: popchami/rakugaking
- Library: ADeL / AI Development Library

## Current Phase

- Phase: Design
- Phase Status: Ready for Implementation Approval
- Discovery Status: Complete
- Bootstrap Status: Complete

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

- Character sharing
- Public character gallery
- Share codes
- User-facing export/import

Temporary character data transfer may still be needed inside online battles, but this is not treated as a sharing feature.

## Template Selection

Selected ADeL set:

- Minimum MVP Set

Additional game-specific documents added during Design:

- DESIGN_DECISIONS.md
- CHARACTER_SPEC.md
- DRAWING_SPEC.md
- DRAWING_TO_PHYSICS_SPEC.md
- COMMAND_SPEC.md
- BATTLE_SPEC.md
- BALANCE_SPEC.md
- ONLINE_SPEC.md
- IMPLEMENTATION_READY_CHECKLIST.md
- IMPLEMENTATION_PHASE_1.md

Additional documents may be added later if needed:

- Asset Spec
- Monetization Spec

## Completed Bootstrap Files

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

## Completed Design Decisions

- First playable MVP is local-first.
- Online battle remains planned but is staged after local core loop validation.
- Character sharing is postponed.
- First drawing approach is 2D drawing applied to simple 3D physics parts.
- First character body type is humanoid only.
- Commands are simple button/card selections.
- First playable MVP does not implement payments.
- Battle uses HP, ring out, and time limit.
- First Unity implementation starts with placeholder physics battle before drawing.
- Drawing-to-physics conversion has an initial ruleset.

## Implementation Entry Point

If the user approves Implementation Phase, start with:

- `docs/IMPLEMENTATION_PHASE_1.md`

## Do Not Do Yet

- Do not implement Unity code until the user approves implementation.
- Do not create final online implementation yet.
- Do not design detailed monetization pricing yet.
- Do not implement character sharing.
- Do not treat assumptions as confirmed specifications.
