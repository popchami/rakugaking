# Command Spec

## Purpose

Define the simple programming system for rakugaking.

## Core Rule

The player does not write code.

The player chooses simple repeated commands from buttons or cards.

## MVP Command Model

A command is assigned to a body part or part group.

Each command repeats automatically during battle.

## MVP Commands

## Punch

Assigned to:

- arm
- hand

Behavior:

- moves arm forward repeatedly
- may hit opponent
- longer arms have more reach but may wobble

## Swing

Assigned to:

- arm
- hand

Behavior:

- rotates or swings arm repeatedly
- useful for chaotic attacks

## Guard

Assigned to:

- arm
- hand

Behavior:

- moves arm into defensive position
- may block incoming attacks

## Kick

Assigned to:

- leg
- foot

Behavior:

- moves leg forward or upward repeatedly
- may destabilize the attacker

## Jump

Assigned to:

- leg
- body

Behavior:

- applies upward force at intervals
- may cause funny falls

## Crouch

Assigned to:

- leg
- body

Behavior:

- lowers body or bends legs
- may improve stability or dodge attacks

## Command Parameters

The first MVP may expose only simple levels:

- weak / normal / strong
- slow / normal / fast

Avoid numeric tuning in the player UI at first.

## Battle Execution

During battle:

1. Character spawns.
2. Commands begin automatically.
3. Commands repeat until battle ends.
4. Physics determines the actual result.

## Design Principle

Commands should be predictable in intention but unpredictable in outcome.

The player should understand what they asked the character to do, even if the result is silly.

## Out of Scope for First MVP

- text programming
- node programming
- if/then logic
- loops created by the player
- advanced AI behavior trees
- custom command scripting

## Future Ideas

- command order
- command timing
- simple combo slots
- personality presets
- special commands by body type
