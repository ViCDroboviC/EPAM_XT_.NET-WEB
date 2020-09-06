
/*const DOMMap = {
    addButtonId: 'add'
}*/

let noteId = 0;
let noteSheet = document.getElementById('noteSheet');
let addButton = document.getElementById('add');

var show = function(state){
    document.getElementById('modalForm').style.display = state;
    document.getElementById('filter').style.display = state;
}

var AddNote = function(){
    console.log("work!")

    var newNoteHead = GetNoteHead();
    var newNoteText = GetNoteText();

    noteSheet.append(CreateNode(noteId, newNoteHead, newNoteText));

    console.log(newNoteHead);
    console.log(newNoteText);
    noteId++;
}

var CreateNode = function(Id, head, text){
    var newNote = document.createElement('div');
    newNote.setAttribute('id', Id);
    newNote.append(CreateHead(head));
    newNote.append(CreateText(text));
    newNote.append(document.createElement('hr'));
}

var CreateHead = function(head){
    var newHead = document.createElement('h2');
    newHead.innerHTML = head;
    return newHead;
}

var CreateText = function(text){
    var newText = document.createElement('p');
    newText.innerHTML = text;
    return newText;
}

var GetNoteHead = function(){
    return document.getElementById('Head').value;
}

var GetNoteText = function(){
    return document.getElementById("newNote").value;
}

addButton.onclick = AddNote;
