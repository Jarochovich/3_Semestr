class Sudoku {
    constructor() {
        this.board = Array.from({ length: 9 }, () => Array(9).fill(0));
        this.initialBoard = JSON.parse(JSON.stringify(this.board));
    }

    resetBoard() {
        this.board = JSON.parse(JSON.stringify(this.initialBoard));
    }

    isValidRow(row) {
        const seen = new Set();

        for (let num of this.board[row]) {
            if (num !== 0 && seen.has(num)) {
                return false;
            }
            seen.add(num);
        }
        return true;
    }

    isValidCol(col) {
        const seen = new Set();

        for (let row = 0; row < 9; row++) {
            const num = this.board[row][col];
            if (num !== 0 && seen.has(num)) {
                return false;
            }
            seen.add(num);
        }
        return true;
    }

    isValidBox(startRow, startCol) {
        const seen = new Set();

        for (let row = 0; row < 3; row++) {
            for (let col = 0; col < 3; col++) {
                const num = this.board[startRow + row][startCol + col];
                if (num !== 0 && seen.has(num)) {
                    return false;
                }
                seen.add(num);
            }
        }
        return true;
    }

    checkBoard() {
        for (let i = 0; i < 9; i++) {
            if (!this.isValidRow(i)) {
                console.log(`Ошибка в строке: ${i + 1}`);
            }
            if (!this.isValidCol(i)) {
                console.log(`Ошибка в столбце: ${i + 1}`);
            }
        }
        for (let row = 0; row < 9; row += 3) {
            for (let col = 0; col < 9; col += 3) {
                if (!this.isValidBox(row, col)) {
                    console.log(`Ошибка в квадрате: (${Math.floor(row / 3) + 1}, ${Math.floor(col / 3) + 1})`);
                }
            }
        }
    }

    generateBoard() {
        // Генерация корректного игрового поля Судоку
        this.solveBoard();
        this.initialBoard = JSON.parse(JSON.stringify(this.board));
    }

    solveBoard() {
        const findEmpty = () => {
            for (let row = 0; row < 9; row++) {
                for (let col = 0; col < 9; col++) {
                    if (this.board[row][col] === 0) {
                        return [row, col];
                    }
                }
            }
            return null;
        };

        const isValid = (num, pos) => {
            const [row, col] = pos;

            // Проверка строки
            for (let i = 0; i < 9; i++) {
                if (this.board[row][i] === num && i !== col) {
                    return false;
                }
            }

            // Проверка столбца
            for (let i = 0; i < 9; i++) {
                if (this.board[i][col] === num && i !== row) {
                    return false;
                }
            }

            // Проверка квадрата 3x3
            const boxRow = Math.floor(row / 3) * 3;
            const boxCol = Math.floor(col / 3) * 3;
            for (let i = boxRow; i < boxRow + 3; i++) {
                for (let j = boxCol; j < boxCol + 3; j++) {
                    if (this.board[i][j] === num && (i !== row || j !== col)) {
                        return false;
                    }
                }
            }

            return true;
        };

        const solve = () => {
            const currPos = findEmpty();
            
            if (currPos === null) {
                return true;
            }

            for (let num = 1; num <= 9; num++) {
                if (isValid(num, currPos)) {
                    const [row, col] = currPos;
                    this.board[row][col] = num;

                    if (solve()) {
                        return true;
                    }

                    this.board[row][col] = 0;
                }
            }

            return false;
        };

        solve();
    }

    printBoard() {
        for (let row of this.board) {
            console.log(row.join(' '));
        }
    }
}


const sudoku = new Sudoku();
sudoku.generateBoard();
sudoku.printBoard();
sudoku.checkBoard();
