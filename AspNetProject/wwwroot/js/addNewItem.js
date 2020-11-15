(function () {
    const alertElement = document.getElementById("success-alert");
    const formElement = document.forms[0];
    const addNewItem = async () => {

        const nameValue = document.getElementById("Name").value;
        const descriptionValue = document.getElementById("Description").value;
        const isVisibleValue = document.getElementById("IsVisible").checked;

        const companyModel = {
            Name: nameValue,
            Description: descriptionValue,
            IsVisible: isVisibleValue
        };

        const response = await fetch("/api/ExchangesSecond/AddNewItem", {
            method: 'POST',
            headers: { "Content-type": "application/json" },
            body: JSON.stringify(companyModel)
        })

        if (response.ok) {
            alertElement.style.display = "block";
            setTimeout(() => {
                    alertElement.style.display = "none";
                },
                2000);

        }
    };
    window.addEventListener("load", () => {
        formElement.addEventListener("submit", event => {
            event.preventDefault();
            addNewItem().then(() => console.log("added successfully"));
        });
    });
})();