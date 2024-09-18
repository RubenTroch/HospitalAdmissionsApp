using HospitalAdmissionsApp.Domain.SeedWorks;

namespace HospitalAdmissionsApp.Domain.Models.ValueObjects;

public class BodyPart : NeissEnumeration {
    public static BodyPart Internal = new(1, 0,"Internal");
    public static BodyPart Shoulder = new(2, 30, "Shoulder");
    public static BodyPart UpperTrunk = new(3, 31, "Upper Trunk");
    public static BodyPart Elbow = new(4, 32, "Elbow");
    public static BodyPart LowerArm = new(5, 33, "Lower Arm");
    public static BodyPart Wrist = new(6, 34, "Wrist");
    public static BodyPart Knee = new(7, 35, "Knee");
    public static BodyPart LowerLeg = new(8, 36, "Lower Leg");
    public static BodyPart Ankle = new(9, 37, "Ankle");
    public static BodyPart PubicRegion = new(10, 38, "Pubic Region");
    public static BodyPart Head = new(11, 75, "Head");
    public static BodyPart Face = new(12, 76, "Face");
    public static BodyPart Eyeball = new(13, 77, "Eyeball");
    public static BodyPart LowerTrunk = new(14, 79, "Lower Trunk");
    public static BodyPart UpperArm = new(15, 80, "Upper Arm");
    public static BodyPart UpperLeg = new(16, 81, "Upper Leg");
    public static BodyPart Hand = new(17, 82, "Hand");
    public static BodyPart Foot = new(18, 83, "Foot");
    public static BodyPart Body25To50Percent= new(19, 84, "25-50% of Body");
    public static BodyPart BodyAllParts = new(20, 85, "All Parts Body");
    public static BodyPart Mouth = new(21, 88, "Mouth");
    public static BodyPart Neck = new(22, 89, "Neck");
    public static BodyPart Finger = new(23, 92, "Finger");
    public static BodyPart Toe = new(24, 93, "Toe");
    public static BodyPart Ear = new(25, 94, "Ear");


    public BodyPart(int id, int neissCode, string name)
        : base(id, neissCode, name)
    {
    }
}