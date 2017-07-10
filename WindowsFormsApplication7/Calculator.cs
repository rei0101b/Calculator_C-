using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;




namespace WindowsFormsApplication7
{


    public partial class Calculator : Form
    {
        const string PLUS = "+";
        const string MINUS = "-";
        const string MULTI = "*";
        const string DIVIDED = "/";
        const string DECIMAL_POINT = ".";
        const int MAX_SHOW_STRING = 18;

        string inputNum;
        string calculationProcess = "";

        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            //    全てが読み込まれた後の処理
        }


        private void btn1_Click(object sender, EventArgs e)
        {
            inputNum = "1";
            inputConnetion(inputNum);
            this.CalculationShow.Text = inputCheck(calculationProcess);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            inputNum = "2";
            inputConnetion(inputNum);
            this.CalculationShow.Text = inputCheck(calculationProcess);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            inputNum = "3";
            inputConnetion(inputNum);
            this.CalculationShow.Text = inputCheck(calculationProcess);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            inputNum = "4";
            inputConnetion(inputNum);
            this.CalculationShow.Text = inputCheck(calculationProcess);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            inputNum = "5";
            inputConnetion(inputNum);
            this.CalculationShow.Text = inputCheck(calculationProcess);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            inputNum = "6";
            inputConnetion(inputNum);
            this.CalculationShow.Text = inputCheck(calculationProcess);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            inputNum = "7";
            inputConnetion(inputNum);
            this.CalculationShow.Text = inputCheck(calculationProcess);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            inputNum = "8";
            inputConnetion(inputNum);
            this.CalculationShow.Text = inputCheck(calculationProcess);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            inputNum = "9";
            inputConnetion(inputNum);
            this.CalculationShow.Text = inputCheck(calculationProcess);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            inputNum = "0";
            inputConnetion(inputNum);
            this.CalculationShow.Text = inputCheck(calculationProcess);
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            //  計算処理
            
           this.CalculationShow.Text = calculate(calculationProcess).ToString();
           
        }

        private void btnDecimalPoint_Click(object sender, EventArgs e)
        {
            inputConnetion(DECIMAL_POINT);
            inputCheck(calculationProcess);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            inputConnetion(PLUS);
            this.CalculationShow.Text = inputOperaterCheck(calculationProcess);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            inputConnetion(MINUS);
            this.CalculationShow.Text = inputOperaterCheck(calculationProcess);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            inputConnetion(DIVIDED);
            this.CalculationShow.Text = inputOperaterCheck(calculationProcess);
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            inputConnetion(MULTI);
            this.CalculationShow.Text = inputOperaterCheck(calculationProcess);
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            // 初期化
            this.CalculationShow.Text = string.Empty;
            calculationProcess = string.Empty;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            // calc = zero;
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            //（保留） 前の数字に1/100をかける
        }


        // --------------------------- 文字列の入力処理　------------------------------------------------------

        //  文字の連結
        public string inputConnetion(string input)
        {
            return calculationProcess += input;
        }

        // 入力した値を加えた文字列をチェックし、表示する
        public string inputCheck(string inputs)
        {
            if (wordsNumberCheck(inputs))
            {
                calculationProcess = inputs;
                return calculationProcess;
            }

            calculationProcess = fixLength(inputs);
            return calculationProcess;
        }

        //  入力された文字数をチェックする（max：18文字）
        public bool wordsNumberCheck(string inputs)
        {
            if (0 < inputs.Length && inputs.Length <= MAX_SHOW_STRING - 1)
            {
                Console.WriteLine("in max range of strings");
                return true;
            }

            Console.WriteLine("out of max range of strings");
            return false;
        }

        // 文字列が最大数である場合入力前の18文字の文字列に直す
        public string fixLength(string inputs)
        {
            string afterfixed = inputs.Remove(MAX_SHOW_STRING - 1, 1);
            return afterfixed;
        }


        //　------------------------ 演算子の入力処理　--------------------------------------------------------------        

        // 演算子が入力された際のチェックし、表示
        public string inputOperaterCheck(string inputs)
        {
            // 初めに入力する文字が演算子の場合は、入力させない
            if (inputs.Length == 1)
            {
                calculationProcess = "";
                return calculationProcess;
            }
            calculationProcess = (operaterDeplication(inputs)) ? operatorOverWrite(inputs) : inputs;
            return calculationProcess;
        }

        // 直前の文字が演算子である場合上書きする
        public string operatorOverWrite(string inputs)
        {
            int length = inputs.Length;
            string afterfixed = inputs.Remove(length - 2, 1);
            return afterfixed;

        }

        // 演算子重複チェック
        public bool operaterDeplication(string inputs)
        {
            int length = inputs.Length;
            string beforeInput = inputs.Substring(length - 2, 1);
          
            if (IsOperater(beforeInput))
            {
                Console.WriteLine("重複あり");
                return true;
            }
            Console.WriteLine("重複なし");
            return false;
        }

        // 前回入力したものが演算子かチェック
        private static bool IsOperater(string beforeInput)
        {
            if (beforeInput == PLUS || beforeInput == MINUS || beforeInput == MULTI || beforeInput == DIVIDED)
            {
                return true;
            }
            return false;
        }


        // ---------------------------------  "="が押された時の計算処理-----------------------------------------



        public int calculate(string inputs)
        {
            // 演算子の位置と値を保持するDictionary
            Dictionary<int, string> findPlus = new Dictionary<int, string>();
            Dictionary<int, string> findMinus = new Dictionary<int, string>();
            Dictionary<int, string> findMulti = new Dictionary<int, string>();
            Dictionary<int, string> findDivided = new Dictionary<int, string>();

            // 各演算子の位置を取得
            findPlus = Find_Index_Operator(inputs, PLUS);
            findMinus = Find_Index_Operator(inputs, MINUS);
            findMulti = Find_Index_Operator(inputs, MULTI);
            findDivided = Find_Index_Operator(inputs, DIVIDED);

            // 全てのDictionaryを結合
            Dictionary<int, string> allIndexOperator = new Dictionary<int, string>();
            allIndexOperator = allIndexOperator.Concat(findPlus).ToDictionary(x => x.Key, x => x.Value);
            allIndexOperator = allIndexOperator.Concat(findMinus).ToDictionary(x => x.Key, x => x.Value);
            allIndexOperator = allIndexOperator.Concat(findMulti).ToDictionary(x => x.Key, x => x.Value);
            allIndexOperator = allIndexOperator.Concat(findDivided).ToDictionary(x => x.Key, x => x.Value);
            
            // 演算子が入力された順にいれるlistを生成
            List<string> operatorList = new List<string>();
            // Dictionaryをキーの値でソート
            var indexSort = allIndexOperator.OrderBy((x) => x.Key);
            foreach (var i in indexSort)
            {
                operatorList.Add(i.Value);
            }
  
            // Dictionaryのidexの位置を保持するlist
            List<int> indexPlace = new List<int>();
            // 文字列の中で演算子の位置を次のように設定　-> <0(初期),3,5,8,文字列の長さ分の値(inputs.length)>
            indexPlace.Add(0);
            indexPlace.AddRange(findIndexPlace(findPlus));
            indexPlace.AddRange(findIndexPlace(findMinus));
            indexPlace.AddRange(findIndexPlace(findMulti));
            indexPlace.AddRange(findIndexPlace(findDivided));
            indexPlace.Add(inputs.Length);

            // リストの中身をソート　ex.<0,7,5,3,9> 　→　<0,3,5,7,9>
            indexPlace.Sort();

            // 取り出した数字を入れるList
            List<int> numberList = new List<int>();

            // 文字列から数字を取り出す
            // 先頭の数字の取得は挙動が異なる
            bool flag = false;
            for (int i = 0; i < indexPlace.Count - 1; ++i)
            {
                if (flag == false)
                {
                    numberList.Add(int.Parse(inputs.Substring(indexPlace[i], indexPlace[i + 1])));
                    flag = true;
                }
                else
                {
                    numberList.Add(int.Parse(inputs.Substring(indexPlace[i] + 1, indexPlace[i + 1] - (indexPlace[i] + 1))));
                }
            }
            //　奇数番目に0を入れる（演算子の位置と仮定） <12,1,32,1> →<12,0,1,0,32,0,1> 
            for (int i = 0; i < numberList.Count; i++)
            {
                if (i % 2 == 1)
                {
                    numberList.Insert(i, 0);
                }
            }

            // ArrayListに数字と演算子を順番に入れる　<12,"+",1,"/",32,"-",1>
            ArrayList sortedInputs = new ArrayList();
            sortedInputs.AddRange(fixSortInputs(numberList, operatorList));
            // 0で割られる式があれば、結果を0とする
            if (zeroBeforeDivided(sortedInputs))
            {
                return 0;
            }
            // 最終計算処理
            int resultCalc = resultCalculate(sortedInputs);
            return resultCalc;
        }


        // 演算子の位置を探す 
        public Dictionary<int, string> Find_Index_Operator(string inputs, string operater)
        {
            // 演算子の位置と種類を保持
            Dictionary<int, string> index_Operator = new Dictionary<int, string>();

            for (int i = 0; i < inputs.Length; ++i)
            {
                // Dictionaryはindexが同じ際、上書きする
                // indexOfが存在しないときは　-1　を返す
                int index = inputs.IndexOf(operater, i);
                // ある演算子が存在しない場合は空の配列を返す
                if (index != -1)
                {
                    index_Operator[index] = operater;
                }
                else
                {
                    break;
                }
            }
            return index_Operator;
        }


        // 演算子のindexの位置を返す
        public List<int> findIndexPlace(Dictionary<int, string> findOperator)
        {
            List<int> indexPlace = new List<int>();
            foreach (KeyValuePair<int, string> index in findOperator)
            {
                indexPlace.Add(index.Key);
            }
            return indexPlace;
        }

        // 演算子を順番に出力する
        public List<string> exportOperator(Dictionary<int, string> allIndexOperator)
        {
            List<string> result = new List<string>();
            foreach (KeyValuePair<int, string> index in allIndexOperator)
            {
                result.Add(index.Value);
            }
            result.Sort();
            return result;
        }

        // 数字のみが入ったNumArrayListの0の部分を演算子を取り換える　<12,0,1,0,32,0,1>　→　<12,+,1,/,32,-,1>
        public ArrayList fixSortInputs(List<int> numberList, List<string> operatorList)
        {
            ArrayList sortNumberOperator = new ArrayList();
            for (int i = 0; i < numberList.Count; i++)
            {
                if (numberList[i] == 0 && i % 2 == 1)
                {
                    // operatorListの演算子を先頭から取り出す
                    sortNumberOperator.Add(operatorList[0]);
                    // 取り出した演算子は削除
                    operatorList.RemoveAt(0);
                    continue;
                }
                sortNumberOperator.Add(numberList[i]);
            }
                return sortNumberOperator;
        }

        //0割りチェック
        public bool zeroBeforeDivided(ArrayList sortedInputs)
        {
            for(int i = 0; i < sortedInputs.Count - 1; ++i)
            {
                string beforeInput = Convert.ToString(sortedInputs[i]);
                string afterInput = Convert.ToString(sortedInputs[i + 1]);
                if (beforeInput == "/" && afterInput == "0")
                {
                    return true;
                }
            }
            return false;
        }

        // 計算メソッド
        public int resultCalculate(ArrayList sortedInputs)
        {
            bool flagTimesDivide = false;
            int processTimes = 0;
            int result = 0;

            // 初めの演算子がプラスもしくはマイナスの場合のとき
            if (sortedInputs[1].ToString() == "+" || sortedInputs[1].ToString() == "-")
            {
                result = Convert.ToInt32(sortedInputs[0]);
            }
            // 初めの演算子が掛け算
            if (sortedInputs[1].ToString() == "*")
            {
                for (int i = 1; i < sortedInputs.Count; i += 2)
                {
                    if (sortedInputs[i].ToString() == "*")
                    {
                        if (flagTimesDivide == false)
                        {
                            processTimes = Convert.ToInt32(sortedInputs[i - 1]);
                            processTimes *= Convert.ToInt32(sortedInputs[i + 1]);
                            result += processTimes;
                            flagTimesDivide = true;
                            continue;
                        }
                        else if (flagTimesDivide == true)
                        {
                            result *= Convert.ToInt32(sortedInputs[i + 1]);
                            continue;
                        }
                    }
                    else if (sortedInputs[i].ToString() == "/")
                    {
                        result /= Convert.ToInt32(sortedInputs[i + 1]);
                        continue;
                    }
                    else if (sortedInputs[i].ToString() == "+" || sortedInputs[i].ToString() == "-")
                    {
                        // のちにプラスがきた時処理を抜ける
                        break;
                    }
                    break;
                }
            } //初めの演算子が割り算の時
            else if (sortedInputs[1].ToString() == "/")
            {
                for (int i = 1; i < sortedInputs.Count; i += 2)
                {
                    if (sortedInputs[i].ToString() == "/")
                    {
                        if (flagTimesDivide == false)
                        {
                            processTimes = Convert.ToInt32(sortedInputs[i - 1]);
                            processTimes /= Convert.ToInt32(sortedInputs[i + 1]);
                            result += processTimes;
                            flagTimesDivide = true;
                            continue;
                        }
                        else if (flagTimesDivide == true)
                        {
                            result /= Convert.ToInt32(sortedInputs[i + 1]);
                            continue;
                        }
                    }
                    else if (sortedInputs[i].ToString() == "*")
                    {
                        result *= Convert.ToInt32(sortedInputs[i + 1]);
                        continue;
                    }
                    else if (sortedInputs[i].ToString() == "+" || sortedInputs[i].ToString() == "-")
                    {
                        // 足し算や引き算がきた時処理を抜ける
                        break;
                    }
                    break;
                }
            }

            // 計算メソッド　初めの演算子以降の処理
            for (int i = 1; i < sortedInputs.Count; i += 2)
            {
            LOOPEND:
                // プラスを見つけた時
                if (sortedInputs[i].ToString() == "+")
                {
                    bool flagPulsMinus = false;
                    int process = 0;
                    // プラスが続く時 かつ　最後の演算子でない (短絡評価の順序を利用してエラーを出さない)
                    if (i != sortedInputs.Count - 2 && sortedInputs[i + 2].ToString() == "+")
                    {
                        result += Convert.ToInt32(sortedInputs[i + 1]);
                        continue;
                    }
                    else if (i == sortedInputs.Count - 2)
                    {
                        // プラス演算子が最後の演算子の時
                        result += Convert.ToInt32(sortedInputs[i + 1]);
                        break;
                    }
                    else
                    {
                        //次にかけるもしくわ割るの演算子がくるとき

                        for (int k = i + 2; k < sortedInputs.Count; k += 2)
                        {
                            if (sortedInputs[k].ToString() == "*" && flagPulsMinus == false)
                            {
                                process = Convert.ToInt32(sortedInputs[k - 1]);
                                process *= Convert.ToInt32(sortedInputs[k + 1]);
                                flagPulsMinus = true;
                                i += 2;
                                continue;
                            }
                            else if (sortedInputs[k].ToString() == "*" && flagPulsMinus == true)
                            {
                                process *= Convert.ToInt32(sortedInputs[k + 1]);
                                i += 2;
                                continue;
                            }
                            else if (sortedInputs[k].ToString() == "/" && flagPulsMinus == false)
                            {
                                process = Convert.ToInt32(sortedInputs[k - 1]);
                                process /= Convert.ToInt32(sortedInputs[k + 1]);
                                flagPulsMinus = true;
                                i += 2;
                                continue;
                            }
                            else if (sortedInputs[k].ToString() == "/" && flagPulsMinus == true)
                            {
                                process /= Convert.ToInt32(sortedInputs[k + 1]);
                                i += 2;
                                continue;
                            }
                            else if (sortedInputs[k].ToString() == "+" || sortedInputs[k].ToString() == "-")
                            {
                                // 次の演算子が足し算もしくは引き算であった場合
                                i += 2;
                                result += process;
                                goto LOOPEND;
                            }
                            else
                            {
                                // 後ろに演算子がないとき
                                result += process;
                                return　result;
                            }
                        }
                    }
                    // 最後の演算子が掛け算であった場合　もしくわ　足し算出会った場合
                    result += process;
                    break;
                }

                // マイナスを見つけた時
                if (sortedInputs[i].ToString() == "-")
                {
                    bool flagPulsMinus = false;
                    int process = 0;
                    // マイナスが続く かつ　最後の演算子でない (短絡評価の順序を利用してエラーを出さない)ß
                    if (i != sortedInputs.Count - 2 && sortedInputs[i + 2].ToString() == "-")
                    {
                        result -= Convert.ToInt32(sortedInputs[i + 1]);
                        continue;
                    }
                    else if (i == sortedInputs.Count - 2)
                    {
                        // プラス演算子が最後の演算子の時
                        result -= Convert.ToInt32(sortedInputs[i + 1]);
                        break;
                    }
                    else
                    {
                        //次にかけるもしくは割るの演算子がくるとき
                        for (int k = i + 2; k < sortedInputs.Count; k += 2)
                        {
                            if (sortedInputs[k].ToString() == "*" && flagPulsMinus == false)
                            {
                                process = Convert.ToInt32(sortedInputs[k - 1]);
                                process *= Convert.ToInt32(sortedInputs[k + 1]);
                                flagPulsMinus = true;
                                i += 2;
                                continue;
                            }
                            else if (sortedInputs[k].ToString() == "*" && flagPulsMinus == true)
                            {
                                process *= Convert.ToInt32(sortedInputs[k + 1]);
                                i += 2;
                                continue;
                            }
                            else if (sortedInputs[k].ToString() == "/" && flagPulsMinus == false)
                            {
                                process = Convert.ToInt32(sortedInputs[k - 1]);
                                process /= Convert.ToInt32(sortedInputs[k + 3]);
                                flagPulsMinus = true;
                                i += 2;
                                continue;
                            }
                            else if (sortedInputs[k].ToString() == "/" && flagPulsMinus == true)
                            {
                                process /= Convert.ToInt32(sortedInputs[k + 1]);
                                i += 2;
                                continue;
                            }
                            else if (sortedInputs[k].ToString() == "+" || sortedInputs[k].ToString() == "/")
                            {
                                // 次の演算子が足し算もしくは引き算であった場合
                                i += 2;
                                result -= process;
                                goto LOOPEND;
                            }
                            else
                            {
                                // 後ろに演算子がないとき
                                result += process;
                                return result;
                            }
                        }
                    }
                    // 最後の演算子が掛け算であった場合　もしくわ　足し算出会った場合
                    result -= process;
                    break;
                }
            }
            // 最終結果
            return result;
        }
              
    }
}
    
        




  