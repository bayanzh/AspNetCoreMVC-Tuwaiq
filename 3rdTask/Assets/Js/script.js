document.addEventListener('DOMContentLoaded', () => {
    const rows = document.querySelectorAll('table tbody tr');
    document.getElementById('total').textContent = rows.length;
});