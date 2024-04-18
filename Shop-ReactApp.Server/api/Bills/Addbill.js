fetch('https://localhost:7284/api/addBill', {
    method: 'POST',
    headers: {
        'Content-Type': 'application/json',
    },
    body: JSON.stringify(newProduct),
})
    .then(response => response.json())
    .then(createdBill => {
        // Xử lý thông tin sản phẩm đã tạo
        console.log(createdBill);
    })
    .catch(error => console.error('Error:', error));