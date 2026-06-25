# Drawing to Physics Spec

## Purpose

This document defines how a player's drawing becomes battle behavior in rakugaking.

This is one of the core specifications of the game.

## Core Principle

The drawing is not only visual.

The drawing affects the character's physical performance.

The goal is not perfect realism. The goal is understandable, funny, strategic chaos.

## First MVP Approach

The first MVP uses:

- 2D drawing for each body part
- simple 3D physics parts
- drawing data converted into basic physics parameters

Direct freeform 3D sculpting is not part of the first MVP.

## Input Data

For each drawn part, calculate:

- bounding box width
- bounding box height
- filled area
- aspect ratio
- center of mass estimate
- stroke density
- connection point offset

## Converted Physics Values

Each drawn part may affect:

- visual size
- collider size
- mass
- reach
- stability
- rotation wobble
- hit power
- movement delay

## Conversion Rules

## 1. Length / Reach

Longer parts increase reach.

Example:

- long arm = punch reaches farther
- long leg = kick reaches farther

Tradeoff:

- longer parts are harder to stabilize
- longer parts wobble more
- longer parts may make the character fall more easily

## 2. Width / Thickness

Wider parts increase mass and durability.

Example:

- thick leg = more stable
- thick arm = stronger impact

Tradeoff:

- wider parts move slower
- heavy parts can pull the body off balance

## 3. Area

Larger filled area increases mass.

Possible effects:

- HP contribution increases slightly
- impact force increases
- movement speed decreases

## 4. Aspect Ratio

Aspect ratio affects stability.

Examples:

- very long and thin arm = high reach, high wobble
- short and thick arm = low reach, high stability
- tall narrow body = easier to topple
- wide body = harder to topple

## 5. Center of Mass

If the drawing is visually heavier on one side, the part's center of mass shifts.

Possible effects:

- attacks curve or swing awkwardly
- character leans
- recovery after movement becomes unstable

For the first MVP, this may be simplified to bounding-box center only.

## 6. Connection Point Offset

If the drawn part is not centered, the connection point may become awkward.

Possible effects:

- arm attaches slightly off-center
- leg movement becomes unbalanced
- punch angle becomes strange

For first MVP, connection points should be clamped to safe ranges.

## Initial Formula Direction

These formulas are starting points and should be tuned during testing.

### Normalized Values

```txt
normalizedLength = clamp(partHeight / guideHeight, 0.5, 1.5)
normalizedWidth = clamp(partWidth / guideWidth, 0.5, 1.5)
areaRatio = clamp(filledPixels / guideArea, 0.1, 1.0)
aspectRatio = partHeight / max(partWidth, smallValue)
```

### Mass

```txt
mass = baseMass * lerp(0.7, 1.6, areaRatio)
```

### Reach

```txt
reach = baseReach * normalizedLength
```

### Stability

```txt
stability = baseStability / normalizedLength * normalizedWidth
```

### Wobble

```txt
wobble = baseWobble * normalizedLength / normalizedWidth
```

### Attack Power

```txt
attackPower = basePower * lerp(0.8, 1.3, areaRatio)
```

### Movement Speed

```txt
movementSpeed = baseSpeed / sqrt(mass)
```

## Part-Specific Rules

## Arms

Drawing effects:

- length affects punch reach
- width/area affects impact
- long thin arms wobble strongly
- heavy arms may pull character forward

## Hands

Drawing effects:

- size affects hit area
- mass slightly affects punch impact
- oversized hands may destabilize arm movement

## Legs

Drawing effects:

- length affects kick reach and stride
- width affects standing stability
- heavy legs slow jumping and kicking

## Feet

Drawing effects:

- width affects balance
- large feet reduce falling
- very large feet may slow movement

## Body

Drawing effects:

- width affects stability
- height affects topple risk
- mass affects resistance to knockback

## Head

Drawing effects:

- size affects top-heaviness
- heavy head increases fall risk
- head hits may be visually funny but should not dominate battle balance

## Safety Clamps

To prevent broken characters, all converted values must be clamped.

Examples:

- minimum mass
- maximum mass
- minimum collider size
- maximum collider size
- maximum wobble
- maximum force
- safe joint limits

## Design Goal for Players

Players should learn simple cause and effect:

- Long reaches farther but becomes unstable.
- Thick is strong but slow.
- Big feet help balance.
- Big heads are funny but risky.

## MVP Implementation Recommendation

For the first implementation after the placeholder battle prototype:

1. Use simple rectangular or capsule colliders.
2. Use drawing bounding box for part size.
3. Use filled area for mass.
4. Use width/height ratio for stability and wobble.
5. Ignore detailed stroke shape until later.

## Out of Scope for First MVP

- complex mesh generation
- detailed skeletal deformation
- full 3D sculpting
- advanced center-of-mass analysis
- online validation of drawing physics

## Related Docs

- `docs/DRAWING_SPEC.md`
- `docs/CHARACTER_SPEC.md`
- `docs/BATTLE_SPEC.md`
- `docs/BALANCE_SPEC.md` if created later
