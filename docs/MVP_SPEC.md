# MVP Spec

## MVP Goal

The MVP is successful when a player can battle using a character they drew.

## MVP Scope

### 1. Drawing Character Parts

The player can draw a simple humanoid character by parts.

MVP body parts:

- head
- body
- left arm
- right arm
- left hand
- right hand
- left leg
- right leg
- left foot
- right foot

The MVP may simplify upper arm / forearm / thigh / shin if needed, but the design should allow later separation.

### 2. Character Assembly

The drawn parts are assembled into a simple physics-based character.

The MVP should prioritize readable behavior over perfect anatomical accuracy.

### 3. Simple Command Assignment

The player can assign simple repeated commands to major parts.

MVP command examples:

- arm: punch
- arm: swing
- arm: guard
- leg: kick
- leg: jump
- leg: crouch

The command system must not require writing code.

### 4. Automatic Battle

Two characters can battle automatically.

Minimum battle modes:

- player-drawn character vs simple test opponent
- player-drawn character vs another saved local character

Online battle is an important product goal. During MVP design, architecture should avoid choices that make online battle impossible later.

### 5. Win/Lose Result

The MVP must show a simple battle result.

Possible result conditions:

- HP reaches 0
- character falls out of arena
- time limit ends and remaining HP decides winner

## Online Battle Direction

Online battle should remain in the product plan.

For the earliest playable MVP, online may be designed in stages:

1. local simulation only
2. shared character data
3. asynchronous battle or ghost battle
4. real-time online battle if feasible

This staging is an implementation strategy, not a removal of online battle.

## Character Sharing Direction

Character sharing should remain in the product plan.

The MVP data model should allow a character to be exported, uploaded, downloaded, or shared later.

## Monetization Direction

Monetization should remain in the product plan.

The MVP does not need final pricing, but it should avoid designs that block monetization later.

Possible paid areas:

- extra character slots
- extra body types
- cosmetic effects
- special drawing tools
- online sharing enhancements

## Out of Scope for First Playable MVP

These are not removed from the product. They are delayed until after the first playable MVP unless explicitly approved.

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

## Open Questions

- Should first playable MVP include online battle directly, or only architecture preparation?
- Should character drawing be 2D strokes converted into 3D parts, or direct 3D drawing?
- What is the simplest battle camera for both smartphone and PC?
- Should HP exist, or should physics knockdown/out-of-bounds decide the winner?
