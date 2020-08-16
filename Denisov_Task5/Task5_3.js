class Storage{
    constructor(data){
        this.data = new array(data)
    }

    Add(object){
        this.data.push(object)
    }

    GetObj(index){
        return this.data[index];
    }

    GetAll(){
        return this.data;
    }
    DeleteById(index){
        let deleted = this.data[index];
        thid.data.splice(index)
        return deleted;
    }

    UpdateById(index, objects){
        this.data.splice(index, objects.length, objects)
    }

    ReplaceById(index, object){
        this.data.delete(index)
        this.data[index] = object
    }
}