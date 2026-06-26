# Character Editor Spec

## Purpose

Define the MVP character editor direction for rakugaking.

This document reflects the confirmed direction from the user:

- The player draws by adding or removing shape around an X/Y axis guide.
- A front arrow shows the direction the character moves forward.
- The editor must be easy enough for children but deep enough for creators.

## Core Principle

The editor must support two play styles:

1. Quick creation for children and casual players.
2. Deeper editing for creators.

The first MVP should prioritize quick creation.

## MVP Creation Loop

The MVP editor supports this loop:

1. Choose body type.
2. Draw or modify parts.
3. Preview movement.
4. Save character.
5. Battle.
6. Edit and try again.

## Body Part Complexity

### Simple Mode

Simple Mode is the default.

It uses fewer parts so a player can quickly draw and battle.

Example humanoid Simple Mode parts:

- head
- body
- left arm
- right arm
- left leg
- right leg

### Creator Mode

Creator Mode allows parts to be split later.

Example split:

```txt
arm
↓
upper arm
lower arm
hand
```

```txt
leg
↓
upper leg
lower leg
foot
```

Creator Mode is important, but it should not block the first playable MVP.

## Body Type Direction

Future body types should support both Simple Mode and Creator Mode.

### Humanoid

Simple Mode:

- head
- body
- left arm
- right arm
- left leg
- right leg

Creator Mode:

- head
- body
- left upper arm
- left lower arm
- left hand
- right upper arm
- right lower arm
- right hand
- left upper leg
- left lower leg
- left foot
- right upper leg
- right lower leg
- right foot

### Dog / Quadruped

Simple Mode:

- head
- body
- front legs
- back legs
- tail

Creator Mode:

- head
- neck
- body
- tail
- left front leg
- right front leg
- left back leg
- right back leg
- feet if needed

### Bird

Simple Mode:

- head
- body
- wings
- legs
- tail feathers

Creator Mode:

- head
- beak
- neck
- body
- left wing
- right wing
- left leg
- right leg
- tail feathers

### Lizard

Simple Mode:

- head
- body
- front legs
- back legs
- tail

Creator Mode:

- head
- neck
- body
- tail base
- tail tip
- left front leg
- right front leg
- left back leg
- right back leg

### Monster

Simple Mode:

- head
- body
- left arm
- right arm
- legs
- optional part

Creator Mode:

- base parts
- horns
- wings
- tail
- tentacles
- spikes
- extra eyes

Monster flexibility is planned for later and is not part of the first MVP implementation.

## Drawing Axes

Each editable part has:

- X axis negative / positive
- Y axis negative / positive
- center guide
- front direction arrow

The front arrow indicates which way the character moves forward.

## Drawing Method

The player edits a base shape by:

- adding volume / meat
- shaving / erasing volume
- painting color

This should feel like drawing and shaping, not technical modeling.

## Base Shapes

The editor provides simple base shapes:

- circle / sphere-like base
- square / box-like base
- capsule
- cylinder-like shape
- simple limb shape

Players can start from a base shape instead of drawing everything from zero.

## Tools

MVP / planned editor tools:

- crayon
- colored pencil
- marker
- brush
- fill
- eraser

Each tool supports thickness levels:

- very thin
- thin
- normal
- thick
- very thick

## Color Palette

The editor uses a palette.

Color count has an upper limit to avoid heavy rendering and data size issues.

MVP recommendation:

- start with a small palette
- show used color count
- prevent unlimited colors

## Preview

The editor has a preview screen.

Preview should allow movement checks before battle.

MVP preview targets:

- idle
- walk / move forward
- jump
- punch
- kick

Preview exists to support quick trial and correction.

## Character Management

The character management system should eventually support:

- save
- load
- edit
- copy
- delete

For the first playable MVP, save/load can be staged after the battle prototype works.

## Postponed Features

The following are postponed and should not be implemented in the current Sprint 1:

- strategy/personality setting
- replay
- medals/achievements
- match result sharing
- GIF/video export
- challenge/theme mode
- random generation
- part lock
- advanced editing tools beyond the MVP editor

Undo/redo may be considered later, but it should not block the first battle prototype.

## Related Docs

- `docs/MVP_SPEC.md`
- `docs/DRAWING_SPEC.md`
- `docs/DRAWING_TO_PHYSICS_SPEC.md`
- `docs/CHARACTER_SPEC.md`
- `docs/UI_WIREFRAME_SPEC.md`
