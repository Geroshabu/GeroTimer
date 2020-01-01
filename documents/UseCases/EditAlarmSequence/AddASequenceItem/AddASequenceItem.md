# Add a sequence item

## 💬 Use Case Description

### Summary

Insert an item to specific position of the alarm sequence.

### Actors

* User

### Primary Flow

1. User clicks "Add New Item" button on the main window.
2. The system shows the "Edit Item" window whose forms are filled by initial values.
3. User inputs parameters of the item, and clicks the "OK" button.
4. The system creates a new item and inserts to the alarm sequence.
5. The system closes the "Edit Item" window.

### Alternative Flows

#### 3-A : If user clicks "Back" button

1. The system closes the "Edit Item" window.
2. Abort this use case.

### Pre-condition

* The main window is displaying

### Post-condition

* The main window is displaying
* If an item had selected on the sequence before step 1, the new item is inserted to previous of it.
* If no item had selected before step 1, the new item is added to last of the sequence.
