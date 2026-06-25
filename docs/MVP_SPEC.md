# MVP Spec

## MVP Goal

The MVP is successful when a player can battle using a character they drew.

## First Playable MVP Decision

The first playable MVP is local-first.

This does not remove online battle or monetization from the product plan. It means the first playable version proves the core fun before adding full online systems.

Character sharing is postponed.

## MVP Scope

### 1. Drawing Character Parts

The player can draw a simple humanoid character by parts.

MVP body parts:

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

If full separation is too complex for the first prototype, it may temporarily use simplified arms and legs, but the data design must allow later separation.

### 2. Drawing Method

The first MVP uses a practical drawing approach:

- player draws 2D shapes or textures
- drawings are applied to simple 3D physics parts
- part size/shape may influence physics values

Direct freeform 3D sculpting is not part of the first playable MVP.

### 3. Character Assembly

The drawn parts are assembled into a simple physics-based humanoid character.

The MVP should prioritize readable behavior over perfect anatomical accuracy.

### 4. Simple Command Assignment

The player can assign simple repeated commands to major parts.

MVP commands:

- punch
- swing
- guard
- kick
- jump
- crouch

The command system must not require writing code.

### 5. Automatic Battle

Two characters can battle automatically.

Minimum battle modes:

- player-drawn character vs simple test opponent
- player-drawn character vs another saved local character

Online battle is an important product goal. During MVP design, architecture should avoid choices that make online battle impossible later.

### 6. Win/Lose Result

The MVP must show a simple battle result.

Result conditions:

- HP reaches 0
- character falls out of arena
- time limit ends and remaining HP decides winner

Recommended first time limit:

- 60 seconds

## Online Battle Direction

Online battle remains in the product plan.

Implementation staging:

1. local battle
2. local saved character battle
3. private room online battle design
4. random matchmaking design
5. real-time online battle if technically feasible

This staging is an implementation strategy, not a removal of online battle.

## Character Sharing Direction

Character sharing is postponed.

Postponed items:

- public character gallery
- share codes
- user-facing character export/import
- browsing other players' characters
- permanent shared character uploads

Online battle may still require temporary transfer of character data inside a match. This is allowed as part of online battle and is not treated as a sharing feature.

## Monetization Direction

Monetization remains in the product plan.

The first playable MVP does not implement payment, but it should avoid designs that block monetization later.

Possible paid areas:

- extra character slots
- extra body types
- cosmetic effects
- special drawing tools

Pay-to-win should be avoided.

## Out of Scope for First Playable MVP

These are delayed until after the first playable MVP unless explicitly approved.

- direct freeform 3D sculpting
- real-time online battle
- character sharing
- public character gallery
- share codes
- user-facing export/import
- payment implementation
- story mode
- campaign mode
- stage editor
- replay editor
- 3+ player battle
- advanced visual scripting
- complex AI behavior trees
- full marketplace economy

## MVP Quality Bar

The MVP should be fun even when it is messy.

Required quality:

- drawing a character feels understandable
- assigning commands feels easy
- battle starts without complex setup
- character movement is funny and readable
- at least one full battle can finish with a result
- player can understand why a drawing choice affected movement

## Related Design Docs

- `docs/DESIGN_DECISIONS.md`
- `docs/CHARACTER_SPEC.md`
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
