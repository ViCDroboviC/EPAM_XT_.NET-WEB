
const DOMMap = {
    noteSheetId: 'noteSheet',
    addButtonId: 'add',
    showAddFormButtonId: 'showAddForm',
    modalFormId: 'modalForm',
    headFormId: 'Head',
    textFormId: "newNote"
}

const notesCollection = [];

let noteId = 0;

let currentNoteForEdit;

let noteSheet = document.getElementById(DOMMap.noteSheetId);
let addButton = document.getElementById(DOMMap.addButtonId);

var show = function(action, button){
    addButton.innerHTML = action;

    if(button != undefined){
        currentNoteForEdit = button.parentNode;
    }

    document.getElementById('modalForm').style.display = 'block';
    document.getElementById('filter').style.display = 'block';    
}

var Hide = function(){
    document.getElementById('modalForm').style.display = 'none';
    document.getElementById('filter').style.display = 'none';
    ClearForm();
}

var ChooseAction = function(){
    console.log('choosing action');
    if(addButton.innerHTML == 'Создать'){
        console.log('creating');
        AddNote();
        console.log('created');
    } else if(addButton.innerHTML == 'Изменить'){
        console.log('editing');
        EditNote(this);
        console.log('edited');
    }
}

var AddNote = function(){
    var newNoteHead = GetNoteHead();
    var newNoteText = GetNoteText();
    ClearForm();

    var newNote = {
        id: noteId,
        head: newNoteHead,
        text: newNoteText
    };

    /*notesCollection.append(newNote);*/

    var newNote = CreateNote(newNote.id, newNote.head, newNote.text);
    noteSheet.appendChild(newNote);

    noteId++;
}

var CreateNote = function(Id, head, text){
    var newNote = document.createElement('div');
    newNote.setAttribute('id', Id);

    var newHead = CreateHead(head);
    newNote.appendChild(newHead);

    var newText = CreateText(text);
    newNote.appendChild(newText);

    var editButton = CreateButton('edit', 'onclick', 'show("Изменить", this)');
    newNote.appendChild(editButton);

    var deleteButton = CreateButton('delete', 'onclick', 'DeleteNote(this)');
    newNote.appendChild(deleteButton);

    newNote.appendChild(document.createElement('hr'));
    return newNote;
}

var CreateHead = function(head){
    var newHead = document.createElement('h2');
    newHead.innerHTML = head;
    return newHead;
}

var CreateText = function(text){
    console.log("Entered in CreateText: " + text);
    var newText = document.createElement('p');
    newText.innerHTML = text;
    return newText;
}

var CreateButton = function(buttonClass, attribute, attributeValue){
    var newButton = document.createElement('button');
    newButton.className = buttonClass;
    newButton.setAttribute(attribute, attributeValue);
    return newButton;
}

var EditNote = function(){
    console.log(currentNoteForEdit);

    var head = currentNoteForEdit.querySelectorAll('h2');
    var text = currentNoteForEdit.querySelectorAll('p');

    head[0].innerHTML = GetNoteHead();
    text[0].innerHTML = GetNoteText();
    console.log('заметка отредактирована');
}

var GetNoteHead = function(){
    return document.getElementById(DOMMap.headFormId).value;
}

var GetNoteText = function(){
    return document.getElementById(DOMMap.textFormId).value;
}

var DeleteNote = function(note){
    note.parentNode.remove();
}

var ClearForm = function(){
    document.getElementById(DOMMap.headFormId).value = '';
    document.getElementById(DOMMap.textFormId).value = '';
}

addButton.onclick = ChooseAction;



