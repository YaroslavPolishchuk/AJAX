    
 let upload = function (personId, methodId,element) {
            let collection;
            let url = "WebPromo.aspx"
            switch (methodId) {
                case '1':
                    collection = fetch(url + "?EmployeeId=" + personId)
                        .then(response => response.text())
                        .then(txt => {
                            element.innerHTML = txt;
                        });
                    break;
                case '2':
                    $.ajax({
                    url:url,
                    data: {EmployeeId:personId}
                    })
                        .done(html => {
                            element.append(html);
                    });
                    break;
                case '3':
                   element.load(url + "?EmployeeId=" + personId);                       
                    break;
                case '4':
                    element.load(url, { EmployeeId: personId });
                    break;
            }            
        }

