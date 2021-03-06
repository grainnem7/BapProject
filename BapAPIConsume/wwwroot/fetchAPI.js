

ShowTableData();

function ShowTableData() {

    // replace xhttp stuff with the Fetch library.
    // https://www.geeksforgeeks.org/javascript-fetch-method/#:~:text=The%2520fetch%2520%2528%2529%2520method%2520in%2520JavaScript%2520is%2520used,JSON%2520or%2520XML.%2520This%2520method%2520returns%2520a%2520promise.

    let xhttp = new XMLHttpRequest();
    xhttp.open("GET", `https://localhost:44329/api/app`, true);
    xhttp.send();
    xhttp.onreadystatechange = function () {
        let tbody = document.getElementById("apiTable").querySelector("tbody");
        let tableContent = "";
        if (this.readyState == 4 && this.status == 200) {
            let jsonData = JSON.parse(this.responseText);

            jsonData.forEach((data, index) => {
                tableContent += `<tr>
        <td>${data.appId}</td>
        <td>${data.category}</td>
        <td>${data.date}</td>
        <td>${data.name}</td>
        <td>${data.noofpeopleRated}</td>
        <td>${data.price}</td>
        <td>${data.rating}</td>
    </tr>`;
            });
            tbody.innerHTML = tableContent;
        }
    };
}
