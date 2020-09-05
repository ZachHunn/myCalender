function fetchTasks(){
    $.ajax({
        url: "/api/tasks",
        type: "GET",
        success: response => {
                console.log("You have grab the list", response)
                for (let i =0;i<response.length; i++){
                    displayTask(response[i])
                }
              
            },
            error: errorDetails => {
                console.log("No Tasks has been fetched", errorDetails)
            }
    })
}

function displayTask(task){
    var container = $("#tasks");
    var syntax = `
        <div class='task'>
            <i class="far fa-circle check"></i> 
            <div class='task-content'>
                <h5 class='task-title'>${task.title}</h5>
                <label class='task-notes'>${task.notes}</label>
            </div>
            <i class='fas fa-star' important></i>
        </div>
    `;

    container.append(syntax)

}

function init(){
    console.log("My Calendar Page");
    
    fetchTasks();

}




window.onload = init;