Module GlobalVariables
    'Colour Pallette
    Public schoolBlue As Color = Color.FromArgb(255, 104, 167, 244)
    Public schoolBrown As Color = Color.FromArgb(255, 87, 37, 0)
    Public DeepBlue As Color = Color.FromArgb(255, 0, 50, 87)
    Public skyOrange As Color = Color.FromArgb(255, 244, 181, 104)
    Public skyYellow As Color = Color.FromArgb(255, 237, 244, 104)
    Public skyRed As Color = Color.FromArgb(255, 244, 111, 104)
    Public skyGreen As Color = Color.FromArgb(255, 167, 244, 104)
    Public Pink As Color = Color.FromArgb(255, 244, 104, 167)
    Public Purple As Color = Color.FromArgb(255, 37, 0, 87)
    Public Green As Color = Color.FromArgb(255, 0, 87, 37)
    Public Teal As Color = Color.FromArgb(255, 0, 87, 81)

    Public currentForm As Form
    Public accessLevel = 0
    '0 = Guest
    '1 = Coach
    '2 = MIC of Rowing

    'Profile Viewing/Editing Variables
    Public SelectedRower As String

    'results Variables between forms
    Public raceEditInfo As String() = Nothing
    Public eventIDnum As Integer

    'Calendar to NewEvent Form reuse
    Public eventSelected = False
    Public selectedEvent As String()

End Module
