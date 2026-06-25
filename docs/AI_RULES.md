# AI Rules

## Purpose

These rules define how AI assistants should work on rakugaking.

## ADeL Rules

AI must follow ADeL phase control.

Current phase:

- Bootstrap

AI must not move to implementation until the user explicitly approves the next phase.

## Evidence Rule

Always separate:

- Confirmed: stated by the user or written in project docs
- Assumption: inferred by AI
- Unknown: not decided yet

Do not write assumptions as confirmed specifications.

## Project-Specific Rules

## 1. Keep Programming Simple

The player must not write code.

Use simple command selection.

Avoid:

- complex scripting
- node graphs in MVP
- condition trees
- advanced AI behavior editors

## 2. Preserve the Funny Chaos

Do not over-correct physics behavior.

The game should remain funny and unstable, but still readable.

## 3. Drawing Is Strategy

Design choices should support the idea that drawing shape affects battle behavior.

## 4. Online / Sharing / Monetization Stay in the Plan

Do not remove these from the product direction:

- online battle
- character sharing
- monetization

Implementation may be staged, but these are product goals.

## 5. MVP First

Prioritize the shortest path to a playable loop:

Draw → Assemble → Command → Battle → Result

## 6. No Implementation Without Spec

Before coding a feature, check:

- PROJECT_OVERVIEW
- MVP_SPEC
- FEATURE_SPEC
- ARCHITECTURE

If the feature is not specified, update docs first.

## 7. Report Work Clearly

When making changes, report:

- files changed
- reason for change
- remaining unknowns
- next recommended step
