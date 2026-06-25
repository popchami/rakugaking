# Character Spec

## Purpose

Define the first playable character structure for rakugaking.

## First Playable Character Type

The first playable MVP uses one humanoid body type.

Future body types remain planned:

- dog-like
- bird-like
- lizard-like
- giant
- yokai
- monster

## MVP Body Parts

The first MVP character is made from these parts:

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

## Simplified Implementation Option

If full part separation is too complex, the first prototype may temporarily use:

- head
- body
- left arm
- right arm
- left leg
- right leg

But the data design should allow later separation into upper/lower parts.

## Character Creation Flow

1. Select humanoid body type.
2. Draw each required part.
3. Preview assembled character.
4. Assign commands.
5. Save character.
6. Use character in battle.

## Physics Properties

Each part should have basic physics values:

- size
- mass
- collider shape
- joint connection
- drag or stability value

## Drawing Affects Strategy

The visual shape should influence battle behavior where possible.

Examples:

- longer arm: better reach, worse stability
- shorter arm: better stability, worse reach
- bigger head: easier to topple
- heavier body: more stable, slower reaction
- longer legs: wider movement, less balance

## MVP Priority

The first version does not need perfect physical realism.

It needs:

- readable character structure
- funny instability
- enough consistency for players to learn from drawing choices

## Character Save Requirements

A saved character must include:

- character name
- body type
- part drawings
- generated part values
- command assignments
- thumbnail if available

## Open Questions

- How much should drawing size affect physics values?
- Should very broken drawings be auto-corrected or allowed?
- Should there be a minimum/maximum size for each part?
