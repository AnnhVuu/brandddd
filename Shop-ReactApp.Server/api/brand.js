fetch('https://localhost:7284/api/brand')
    .then(response => response.json())
    .then(brand => {
        // Xử lý danh sách sản phẩm
        console.log(brand);
    })
    .catch(error => console.error('Error:', error));
/*const Idbrand = 1;*/

const brandID = 1;
fetch(`https://localhost:7284/api/brand/${brandId}`)
    .then(response => response.json())
    .then(brand => {
        // Xử lý thông tin chi tiết sản phẩm
        console.log(brand);
    })
    .catch(error => console.error('Error:', error));
const newbrand = {
    name: 'New brand',
    price: 100,
    description: 'A new brand',
    IdBrand: '1'
    // Thêm các thông tin khác
};
fetch('https://localhost:7284/api/brand', {
    method: 'POST',
    headers: {
        'Content-Type': 'application/json',
    },
    body: JSON.stringify(newbrand),
})
    .then(response => response.json())
    .then(createdbrand => {
        // Xử lý thông tin sản phẩm đã tạo
        console.log(createdbrand);
    })
    .catch(error => console.error('Error:', error));
// Thay {id} và cập nhật thông tin sản phẩm
const brandIDToUpdate = 1;
const updatedbrand = {
    id: brandIDToUpdate,
    name: 'Updated brand',
    price: 150,
    description: 'An updated brand',
    // Thêm các thông tin khác
};
const brandIDToDelete = 1;
fetch(`https://localhost:7284/api/brand/${brandIDToDelete}`, {
    method: 'DELETE',
})
    .then(response => {
        if (response.status === 204) {
            console.log('brand deleted successfully.');
        } else {
            console.error('Failed to delete brand.');
        }
    })
    .catch(error => console.error('Error:', error));



