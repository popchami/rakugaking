# Balance Spec

## Purpose

Define the first balance direction for rakugaking.

The goal is not strict competitive fairness at first.

The goal is funny, understandable battles where drawing choices matter.

## Core Balance Principle

Every advantage should create a weakness.

Examples:

- Long arm: reach up, stability down
- Thick arm: power up, speed down
- Big feet: balance up, agility down
- Heavy body: knockback resistance up, recovery speed down
- Big head: funny impact up, fall risk up

## First MVP Balance Goals

The first playable MVP should make these effects visible:

1. Long parts feel unstable.
2. Thick parts feel heavy.
3. Wide feet improve balance.
4. Big heads make falling easier.
5. Commands are understandable even when outcomes are chaotic.

## Main Parameters

## Reach

Affected by:

- arm length
- leg length

Benefit:

- easier to hit opponent

Cost:

- more wobble
- worse recovery
- higher fall risk

## Mass

Affected by:

- filled area
- part thickness

Benefit:

- stronger impact
- harder to knock away

Cost:

- slower motion
- more self-destabilization

## Stability

Affected by:

- foot width
- leg width
- body width
- center of mass

Benefit:

- less falling
- better recovery

Cost:

- may reduce agility if achieved through heavy/wide parts

## Wobble

Affected by:

- long thin parts
- off-center drawings
- high-force commands

Benefit:

- funny unpredictable hits

Cost:

- lower accuracy
- self knockdown risk

## Attack Power

Affected by:

- part mass
- command strength
- collision speed

Benefit:

- more damage

Cost:

- slower recovery
- higher self-balance risk

## First MVP Starting Values

These values are placeholders for tuning.

```txt
Base HP: 100
Battle Time: 60 seconds
Base Arm Damage: 8
Base Leg Damage: 12
Ring Out: instant loss
Draw: equal HP at time up
```

## Recommended Tuning Ranges

```txt
Mass multiplier: 0.7 to 1.6
Reach multiplier: 0.5 to 1.5
Stability multiplier: 0.5 to 1.8
Wobble multiplier: 0.5 to 2.0
Attack power multiplier: 0.8 to 1.3
Movement speed multiplier: 0.6 to 1.4
```

## Command Balance

## Punch

Role:

- basic arm attack

Balance:

- fast
- medium damage
- medium risk

## Swing

Role:

- chaotic arm attack

Balance:

- wide hit area
- unpredictable
- high self-destabilization risk

## Guard

Role:

- defensive command

Balance:

- reduces damage from front
- may reduce attack frequency

## Kick

Role:

- strong leg attack

Balance:

- higher damage than punch
- high fall risk
- slower recovery

## Jump

Role:

- movement/disruption command

Balance:

- can dodge or create surprise attacks
- high chaos
- high fall risk

## Crouch

Role:

- stability/dodge command

Balance:

- improves balance
- may reduce reach
- may avoid high attacks

## Anti-Dominant Strategy Rules

The game should avoid one best drawing.

Examples:

- Very long arms must become unstable.
- Very heavy bodies must become slow.
- Very wide feet must reduce agility or turning.
- Very large hands must increase arm wobble.

## First Testing Focus

During testing, check:

- Do long arms visibly reach farther?
- Do long arms also fail hilariously sometimes?
- Do big feet help the character stand?
- Does kick feel powerful but risky?
- Does the battle end reliably?
- Can the player understand why they lost?

## Competitive Direction

rakugaking is not primarily an esports game.

It should support fun competition, but comedy and creativity are more important than perfect balance.

## Related Docs

- `docs/DRAWING_TO_PHYSICS_SPEC.md`
- `docs/COMMAND_SPEC.md`
- `docs/BATTLE_SPEC.md`
