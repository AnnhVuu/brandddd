fetch('https://localhost:7284/api/bill')
    .then(response => response.json())
    .then(bill => {
        // Xử lý danh sách sản phẩm
        console.log(bill);
    })
    .catch(error => console.error('Error:', error));
/*const IdBill = 1;*/

const billID = 1;
fetch(`https://localhost:7284/api/bill/${billId}`)
    .then(response => response.json())
    .then(bill => {
        // Xử lý thông tin chi tiết sản phẩm
        console.log(Bill);
    })
    .catch(error => console.error('Error:', error));
const newBill = {
    name: 'New Bill',
    price: 100,
    description: 'A new bill',
    IdBrand: '1'
    // Thêm các thông tin khác
};
fetch('https://localhost:7284/api/bill', {
    method: 'POST',
    headers: {
        'Content-Type': 'application/json',
    },
    body: JSON.stringify(newBill),
})
    .then(response => response.json())
    .then(createdBill => {
        // Xử lý thông tin sản phẩm đã tạo
        console.log(createdBill);
    })
    .catch(error => console.error('Error:', error));
// Thay {id} và cập nhật thông tin sản phẩm
const billIDToUpdate = 1;
const updatedBill = {
    id: billIDToUpdate,
    name: 'Updated Bill',
    price: 150,
    description: 'An updated Bill',
    // Thêm các thông tin khác
};
const billIDToDelete = 1;
fetch(`https://localhost:7284/api/Bill/${billIDToDelete}`, {
    method: 'DELETE',
})
    .then(response => {
        if (response.status === 204) {
            console.log('Bill deleted successfully.');
        } else {
            console.error('Failed to delete Bill.');
        }
    })
    .catch(error => console.error('Error:', error));



