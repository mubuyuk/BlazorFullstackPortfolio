window.bootstrapModal = {
    show: (id) => {
        var modalElement = document.querySelector(id);
        var modal = new bootstrap.Modal(modalElement);

        modalElement.removeAttribute("aria-hidden");
        modal.show();
    },
    hide: (id) => {
        var modalElement = document.querySelector(id);
        var modal = bootstrap.Modal.getInstance(modalElement);

        if (modal) {
            modal.hide();

            modalElement.addEventListener('hidden.bs.modal', function () {
                modalElement.setAttribute("aria-hidden", "true");
            }, { once: true });
        }
    }
};


