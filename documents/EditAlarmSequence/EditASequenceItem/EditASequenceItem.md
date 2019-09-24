# Edit a sequence item

## 💬 Use Case Description

### Summary

Edit specified item of the alarm sequence.

### Actors

* User

### Primary Flow

1. User clicks "Edit Item" button of a sequence item on the main window.
2. The system shows the "Edit Item" window whose each forms are filled by values of the item selected at step 1.
3. User inputs parameters of the item, and clicks the "OK" button.
4. The system updates the item.
5. The system closes the "Edit Item" window.

### Alternative Flows

#### 3-A : If user cancels

1. Abort this use case

#### 4-A : If inputs are invalid

1. The system shows an error dialog.
2. User closes the error dialog.
3. Back to step 3 of primary flow.

### Pre-condition

* The main window is displaying

### Post-condition

* The main window is displaying according to the edited item
