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
- automatic command execution
- simple arena
- clear result

## Battle Setup

Before battle:

1. Select Character A.
2. Select Character B or test opponent.
3. Confirm commands.
4. Start battle.

## Arena

MVP arena:

- flat platform
- visible boundaries
- fall/ring-out area

Future arenas may add hazards or themes.

## Battle Camera

MVP camera should prioritize readability.

Recommended:

- fixed side-view or angled view
- both characters visible
- minimal camera movement

## Battle Rules

A battle ends when one of these happens:

- a character HP reaches 0
- a character falls out of arena
- time limit ends

If time limit ends:

- higher remaining HP wins
- equal HP becomes draw

## HP Direction

HP exists for clarity.

HP can be reduced by:

- attack collision
- strong impact
- falling impact if needed

## Ring Out Direction

Ring out exists to preserve physics comedy.

A character loses if it falls below the arena or exits the battle area.

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

- download opponent character data
- simulate battle locally
- upload result
- later evaluate real-time online if feasible

## Out of Scope for First MVP

- 3+ player battle
- real-time ranked matchmaking
- stage hazards
- replay editor
- spectator mode
- complex tournament system
