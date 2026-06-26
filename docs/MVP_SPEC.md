# MVP Spec

## MVP Goal

The MVP is successful when a player can battle using a character they drew.

## First Playable MVP Decision

The first playable MVP is local-first.

This does not remove online battle or monetization from the product plan. It means the first playable version proves the core fun before adding full online systems.

Character sharing is postponed.

## MVP Core Loop

The MVP should focus on this loop only:

1. Choose a body type.
2. Draw or modify body parts.
3. Preview movement.
4. Save character.
5. Battle.
6. Edit and try again.

## MVP Scope

### 1. Character Editor

The player can create a character using a simple part-based editor.

The editor uses X/Y axis guides and a forward direction arrow.

The player edits from base shapes by:

- adding volume / meat
- shaving / erasing volume
- painting color

### 2. Simple Mode First

The MVP should prioritize Simple Mode so children can quickly draw and play.

Simple humanoid parts:

- head
- body
- left arm
- right arm
- left leg
- right leg

Creator Mode with finer part splitting is planned later but should not block the first playable MVP.

### 3. Drawing Tools

Planned editor tools:

- crayon
- colored pencil
- marker
- brush
- fill
- eraser

Each tool can support thickness levels later:

- very thin
- thin
- normal
- thick
- very thick

The first editor implementation may start with fewer tools if needed.

### 4. Color Palette

The editor uses a palette.

Color count has an upper limit to avoid heavy rendering and data size issues.

### 5. Drawing Method

The first MVP uses a practical drawing approach:

- player modifies simple base shapes
- drawings are applied to simple 3D physics parts
- part size/shape may influence physics values

Direct freeform 3D sculpting is not part of the first playable MVP.

### 6. Character Assembly

The drawn parts are assembled into a simple physics-based humanoid character.

The MVP should prioritize readable behavior over perfect anatomical accuracy.

### 7. Preview

The editor includes a preview step.

Preview should help players quickly test whether the character moves in a funny or usable way.

MVP preview targets:

- idle
- move forward
- jump
- punch
- kick

### 8. Character Management

The character system should eventually support:

- save
- load
- edit
- copy
- delete

For the first playable MVP, save/load should be prioritized before copy/delete.

### 9. Automatic Battle

Two characters can battle automatically.

Minimum battle modes:

- player-created character vs simple test opponent
- player-created character vs another saved local character

Online battle is a future product goal. It is not implemented in the current MVP implementation phase.

### 10. Win/Lose Result

The MVP must show a simple battle result.

Result conditions:

- HP reaches 0
- time limit ends and remaining HP decides winner
- emergency fall below stage ends battle as a safety rule

The main arena pressure rule is a shrinking ring that pushes fighters toward the center.

Recommended first time limit:

- 60 seconds

## Out of Scope for First Playable MVP

These are delayed unless explicitly approved.

- direct freeform 3D sculpting
- real-time online battle
- character sharing
- public character gallery
- share codes
- user-facing export/import
- payment implementation
- strategy/personality setting
- replay editor
- medals/achievements
- match result sharing
- GIF/video export
- challenge/theme mode
- random generation
- part lock
- story mode
- campaign mode
- stage editor
- 3+ player battle
- advanced visual scripting
- complex AI behavior trees
- full marketplace economy

## MVP Quality Bar

The MVP should be fun even when it is messy.

Required quality:

- drawing a character feels understandable
- simple mode lets players create quickly
- preview helps players test and fix
- battle starts without complex setup
- character movement is funny and readable
- at least one full battle can finish with a result
- player can understand why a drawing choice affected movement

## Related Design Docs

- `docs/DESIGN_DECISIONS.md`
- `docs/CHARACTER_SPEC.md`
- `docs/CHARACTER_EDITOR_SPEC.md`
- `docs/DRAWING_SPEC.md`
- `docs/DRAWING_TO_PHYSICS_SPEC.md`
- `docs/COMMAND_SPEC.md`
- `docs/BATTLE_SPEC.md`
- `docs/BALANCE_SPEC.md`
- `docs/ONLINE_SPEC.md`

## Remaining Open Questions

- How strongly should drawing size affect physics values?
- What exact Unity networking solution should be used later?
- What monetization model should be selected later?
