# Design Decisions

## Purpose

This document records the first Design Phase decisions for rakugaking.

The goal is to make the first playable MVP small enough to build while preserving the long-term goals of online battle, character sharing, and monetization.

## Decision 001: First Playable MVP Scope

### Decision

The first playable MVP will be local-first.

It will include:

- one humanoid character body type
- part-based drawing
- simple command selection
- automatic battle
- local save/load
- battle result

### Reason

The riskiest part of the project is not online battle. The riskiest part is making drawn characters turn into funny, readable, physics-based fighters.

Online battle should remain in the product plan, but it should not block proving the core play loop.

### Status

Accepted for Design Phase.

## Decision 002: Online Battle Staging

### Decision

Online battle will be staged.

Recommended stages:

1. Local battle
2. Character export/import
3. Shared character download battle
4. Asynchronous online battle
5. Real-time online battle only if technically feasible

### Reason

Real-time physics synchronization is difficult and may slow the project too early.

The game can still feel online if players can share characters and fight downloaded characters.

### Status

Accepted for Design Phase.

## Decision 003: Drawing Method for First MVP

### Decision

The first MVP should avoid complex freeform 3D sculpting.

Recommended first approach:

- player draws 2D shapes or textures for body parts
- those drawings are attached to simple 3D physics parts
- the character behaves as a 3D physics ragdoll-like fighter

### Reason

Direct 3D drawing is too risky for the first implementation.

Using simple 3D parts with drawn visuals allows the project to test the core fun faster.

### Status

Accepted for Design Phase.

## Decision 004: Character Body Type

### Decision

The first playable MVP uses only a humanoid body type.

Future body types such as dog, bird, lizard, giant, yokai, and monster remain planned but are not part of the first playable MVP.

### Reason

Multiple skeletons would increase complexity before the core battle loop is proven.

### Status

Accepted for Design Phase.

## Decision 005: Command System

### Decision

Commands are selected from buttons/cards.

No text coding, visual scripting, node graph, or conditional logic is included in the first playable MVP.

### MVP Commands

- punch
- swing
- guard
- kick
- jump
- crouch

### Reason

The user explicitly wants programming to not be difficult.

### Status

Accepted for Design Phase.

## Decision 006: Monetization Staging

### Decision

The first playable MVP will not implement payment.

However, monetization remains a planned product goal and the design should avoid pay-to-win.

Possible future monetization:

- extra character slots
- cosmetic effects
- extra body types
- special drawing materials
- sharing features

### Reason

Payment systems should not be added before the core game is fun.

### Status

Accepted for Design Phase.

## Decision 007: Win Condition

### Decision

The first playable MVP should use a simple hybrid win condition:

- HP reaches 0
- ring out / fall out of arena
- time limit ends, then remaining HP decides

### Reason

Pure physics-only win conditions may be funny but hard to tune.

HP gives clear results while ring out preserves physical comedy.

### Status

Accepted for Design Phase.

## Next Design Tasks

1. Create Character Spec.
2. Create Battle Spec.
3. Create Command Spec.
4. Create Drawing Spec.
5. Update MVP_SPEC with these decisions.
