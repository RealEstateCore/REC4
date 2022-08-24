[Point](../../../../../Point.md) > [Parameter](../../../../Parameter.md) > [PID_Parameter](../../../PID_Parameter.md) > [Time_Parameter](../../Time_Parameter.md) > [Integral_Time_Parameter](../Integral_Time_Parameter.md) > [Static_Pressure_Integral_Time_Parameter](.)
# Static_Pressure_Integral_Time_Parameter

**Display name:** Static Pressure Integral Time Parameter<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Static_Pressure_Integral_Time_Parameter;1

---


## Child interfaces
* [Discharge_Air_Static_Pressure_Integral_Time_Parameter](Discharge_Air_Static_Pressure_Integral_Time_Parameter.md)
* [Supply_Air_Static_Pressure_Integral_Time_Parameter](Supply_Air_Static_Pressure_Integral_Time_Parameter.md)

---
## Relationships
### Inherited Relationships
* **dtmi:org:brickschema:schema:Brick:Point;1:** isPointOf
## Properties
### Inherited Properties
* **dtmi:org:brickschema:schema:Brick:Point;1:** aggregate, customTags, externalIds, hasQuantity, hasSubstance, lastKnownValue, name
## Target Of
### Inherited
* Asset.hasPoint
* EquipmentCollection.hasPoint
* ActuationEvent.targetPoint
* ExceptionEvent.sourcePoint
* ObservationEvent.sourcePoint
* ServiceObject.producedBy
* Architecture.hasPoint
