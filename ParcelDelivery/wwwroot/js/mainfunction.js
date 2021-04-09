function convertToDataTableFrom(responseData) {
    var cityArr = [];
    for (var i = 0; i < responseData.length; i++) {
        var singleArr = [responseData[i].id, responseData[i].name, responseData[i].code, null];
        cityArr.push(singleArr);
    }
    return cityArr;
}

function convertUserToDataTable(responseData) {
    var userData = [];
    for (var i = 0; i < responseData.length; i++) {
        var role = responseData[i].role === 1 ? 'Admin' : 'Employee';
        var singleArr = [responseData[i].id, responseData[i].name, role, null];
        userData.push(singleArr);
    }
    return userData;
}