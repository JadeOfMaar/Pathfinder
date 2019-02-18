﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using KSP.IO;

/*
Source code copyright 2018, by Michael Billard (Angel-125)
License: GPLV3

Wild Blue Industries is trademarked by Michael Billard and may be used for non-commercial purposes. All other rights reserved.
Note that Wild Blue Industries is a ficticious entity 
created for entertainment purposes. It is in no way meant to represent a real entity.
Any similarity to a real entity is purely coincidental.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/
namespace WildBlueIndustries
{
    public class GoldStrikeSettings : GameParameters.CustomParameterNode
    {
        [GameParameters.CustomFloatParameterUI("Prospect Reset Cost", maxValue = 500.0f, minValue = 10.0f, toolTip = "How much for extra prospects?", autoPersistance = true, gameMode = GameParameters.GameMode.SCIENCE | GameParameters.GameMode.CAREER)]
        public float prospectResetCost = 100.0f;

        [GameParameters.CustomIntParameterUI("Bonus Per Prospect Skill", maxValue = 10, minValue = 1, stepSize = 1, toolTip = "What are those skill points worth?", autoPersistance = true, gameMode = GameParameters.GameMode.ANY)]
        public int bonusPerSkillPoint = 1;

        #region Properties

        public static float ProspectResetCost
        {
            get
            {
                GoldStrikeSettings settings = HighLogic.CurrentGame.Parameters.CustomParams<GoldStrikeSettings>();
                return settings.prospectResetCost;
            }
        }

        public static int BonusPerSkillPoint
        {
            get
            {
                GoldStrikeSettings settings = HighLogic.CurrentGame.Parameters.CustomParams<GoldStrikeSettings>();
                return settings.bonusPerSkillPoint;
            }
        }

        #endregion

        #region GameParameters.CustomParameterNode
        public override GameParameters.GameMode GameMode
        {
            get
            {
                return GameParameters.GameMode.ANY;
            }
        }

        public override bool HasPresets
        {
            get
            {
                return false;
            }
        }

        public override string DisplaySection
        {
            get 
            {
                return Section;
            }
        }

        public override string Section
        {
            get
            {
                return "Pathfinder";
            }
        }

        public override int SectionOrder
        {
            get
            {
                return 0;
            }
        }

        public override string Title
        {
            get
            {
                return "Gold Strike";
            }
        }
        #endregion
    }
}
