# Battle Spec

## Purpose

Define the first playable battle rules for rakugaking.

## Battle Concept

Battles are automatic.

The player prepares the character, but does not directly control it during battle.

The fun comes from simple commands interacting with strange drawings and physics.

## MVP Battle Mode

The first playable MVP includes:

- 1 vs 1 battle
- local battle
- humanoid vs humanoid
- automatic battle behavior
- simple shrinking arena
- clear result

## Battle Setup

Before battle:

1. Select Character A.
2. Select Character B or test opponent.
3. Confirm setup.
4. Start battle.

## Arena

MVP arena:

- flat platform
- visible shrinking boundary
- shrinking boundary pushes fighters toward the center
- no instant fall-based ring-out as the main rule

Future arenas may add hazards or themes.

## Battle Camera

MVP camera should prioritize readability.

Recommended:

- fixed side-view or angled view
- both characters visible
- shrinking ring remains visible
- minimal camera movement

## Battle Rules

A battle ends when one of these happens:

- a character HP reaches 0
- time limit ends
- optional emergency fall below the stage occurs

If time limit ends:

- higher remaining HP wins
- equal HP becomes draw

## HP Direction

HP exists for clarity.

HP can be reduced by:

- attack collision
- strong impact
- falling impact if needed

The shrinking ring itself should not directly deal HP damage in the current design.

## Shrinking Ring Direction

The battle area shrinks over time.

Purpose:

- prevent passive battles
- force fighters closer together
- increase contact and chaos near the end
- avoid instant random defeat from early ring-out

Recommended first values:

```txt
Start size: 100%
Shrink start: after 10 seconds
Minimum size: 50%
Full shrink time: 60 seconds
Outside ring: push fighter toward center
```

Sprint 1 may implement this as a shrinking rectangular boundary.

If a fighter is outside the current ring area, the ring applies an inward force toward the center. The ring should behave like a moving wall that compresses the fight space, not a damage zone.

## Emergency Fall Direction

A character falling far below the stage may still trigger defeat as a safety rule.

This is not the main battle mechanic.

Purpose:

- prevent endless falling states
- end broken physics cases cleanly

## Time Limit

MVP battle should have a short time limit.

Recommended initial value:

- 60 seconds

This can be tuned later.

## Battle Result

Result screen shows:

- winner
- loser or draw
- reason
- rematch option
- edit character option

## Test Opponent

The MVP may include a simple test opponent.

Purpose:

- allow battle testing even with only one saved character
- verify commands and physics quickly

## Online Battle Direction

Online battle remains planned.

The first battle system should avoid hard local-only assumptions.

Possible future format:

- transfer selected character data temporarily inside a match
- simulate battle
- later evaluate real-time online if feasible

## Out of Scope for First MVP

- 3+ player battle
- real-time ranked matchmaking
- stage hazards
- replay editor
- spectator mode
- complex tournament system
