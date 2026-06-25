# AI Rules

## Metadata

| Item | Value |
|---|---|
| Project Name | rakugaking |
| Status | Draft |
| Version | 0.1.0 |
| Created | 2026-06-25 |
| Updated | 2026-06-25 |

---

## 1. Core Principle

AIは、速く作ることよりも、仕様に正確に従うことを優先します。

判断に迷った場合は、実装を進める前に仕様書を確認します。

---

## 2. Reading Order

AIは作業前に、必要に応じて以下の順番で読みます。

1. README.md
2. docs/00_START_HERE.md
3. docs/PROJECT_OVERVIEW.md
4. docs/MVP_SPEC.md
5. docs/ARCHITECTURE.md
6. docs/DATA_SPEC.md
7. docs/UI_UX_SPEC.md
8. docs/FEATURE_SPEC.md
9. docs/TEST_PLAN.md
10. docs/HANDOFF.md

---

## 3. Forbidden Actions

### Feature

- 仕様にない機能を追加しない
- MVP外の機能を実装しない
- 便利そうという理由で機能を増やさない

### UI

- 勝手に画面を追加しない
- 勝手にボタンを追加しない
- 勝手に色やフォントを変えない
- UI_UX_SPEC にないレイアウト変更をしない

### Data

- DATA_SPEC にないフィールドを追加しない
- 型を勝手に変更しない
- 保存方式を勝手に変更しない

### Architecture

- 新しいライブラリを勝手に導入しない
- ディレクトリ構成を勝手に変えない
- 状態管理や設計方式を勝手に変更しない

### Refactoring

- 指示されていない大規模リファクタリングをしない
- 動いているコードを理由なく書き換えない
- 命名を勝手に変更しない

---

## 4. Implementation Rule

実装する時は以下の順番で進めます。

1. 対象機能の仕様を確認する
2. 関連するデータ仕様を確認する
3. 関連するUI仕様を確認する
4. 既存実装の構成を確認する
5. 最小変更で実装する
6. テストまたは確認手順を作る
7. HANDOFF.md を更新する

---

## 5. Decision Rules

### 新しい画面が必要な場合

既存画面で実現できる場合、新規画面は追加しません。

新規画面が必要な場合は、先に UI_UX_SPEC を更新します。

### 新しいデータ項目が必要な場合

DATA_SPEC に存在しない項目は追加しません。

必要な場合は、先に DATA_SPEC を更新します。

### 新しいライブラリが必要な場合

標準機能または既存ライブラリで実現できる場合、新規ライブラリは追加しません。

追加が必要な場合は、ARCHITECTURE.md に理由を記録します。

### MVP外の改善を思いついた場合

実装せず、HANDOFF.md に将来候補として記録します。

---

## 6. Review Rule

AIレビューでは以下を確認します。

- MVP_SPEC に一致しているか
- FEATURE_SPEC に一致しているか
- DATA_SPEC と矛盾していないか
- UI_UX_SPEC と矛盾していないか
- ARCHITECTURE に従っているか
- 既存機能を壊していないか
- エラー処理があるか
- テストまたは確認手順があるか

---

## 7. Response Format

```txt
実施内容:
-

変更ファイル:
-

仕様との対応:
-

確認方法:
-

未完了:
-

次にやること:
-
```
