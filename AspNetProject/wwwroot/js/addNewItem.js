(function () {
    const alertElement = document.getElementById("success-alert");
    const formElement = document.forms[0];
    const addNewItem = async () => {
        let formData = {
            Name: "aThing",
            Description: "FancyThing Here ",
            IsVisible: true
        };

        const response = await fetch("/api/Listing", {
            method: 'POST',
            headers: { "Content-type": "application/json" },
            body: JSON.stringify(formData)
        })

        if (response.ok) {
            alertElement.style.display = "block";
        }
    };
    window.addEventListener("load", () => {
        formElement.addEventListener("submit", event => {
            event.preventDefault();
            addNewItem().then(() => console.log("added successfully"));
        });
    });
})();