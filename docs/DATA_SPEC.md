# Data Specification

## Metadata

| Item | Value |
|---|---|
| Project Name | rakugaking |
| Status | Draft |
| Version | 0.1.0 |
| Created | 2026-06-25 |
| Updated | 2026-06-25 |

---

## 1. Purpose

このドキュメントの目的は、データ定義のズレを防ぎ、AIが勝手にフィールドや保存方式を変更しないようにすることです。

現時点では、扱うデータは未定です。

---

## 2. Storage Policy

| Item | Value |
|---|---|
| Storage Type | TBD |
| Database | TBD |
| Backup | TBD |
| Sync | TBD |
| Offline Support | TBD |

---

## 3. Entities

| Data ID | Entity Name | Purpose | MVP |
|---|---|---|---|
| DATA-001 | TBD | 未定 | TBD |

---

## 4. Entity Detail

## DATA-001: TBD

### Purpose

未定。

### Fields

| Field | Type | Required | Default | Validation | Notes |
|---|---|---|---|---|---|
| id | string | Yes | auto | unique | 識別子 |

---

## 5. Relationships

| From | To | Type | Notes |
|---|---|---|---|
| TBD | TBD | TBD | 未定 |

---

## 6. Validation Rules

| Entity | Field | Rule | Error Message |
|---|---|---|---|
| TBD | TBD | TBD | TBD |

---

## 7. Data Lifecycle

| Event | Description |
|---|---|
| Create | 未定 |
| Read | 未定 |
| Update | 未定 |
| Delete | 未定 |
| Backup | 未定 |

---

## 8. Migration Policy

- データ構造を変更する場合は、このドキュメントを先に更新する
- 既存データへの影響を確認する
- 必要な場合はマイグレーション手順を作成する
- 破壊的変更は理由を記録する

---

## 9. AI Instructions

AIは以下を守ること。

- このドキュメントにないフィールドを勝手に追加しない
- 型を勝手に変更しない
- 保存方式を勝手に変更しない
- データ変更が必要な場合は、先にこのファイルを更新する
