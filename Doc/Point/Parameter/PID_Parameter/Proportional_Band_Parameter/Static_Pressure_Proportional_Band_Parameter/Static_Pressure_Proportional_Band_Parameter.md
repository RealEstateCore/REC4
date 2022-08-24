[Point](../../../../Point.md) > [Parameter](../../../Parameter.md) > [PID_Parameter](../../PID_Parameter.md) > [Proportional_Band_Parameter](../Proportional_Band_Parameter.md) > [Static_Pressure_Proportional_Band_Parameter](#)
# Static_Pressure_Proportional_Band_Parameter

**Display name:** Static Pressure Proportional Band Parameter<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Static_Pressure_Proportional_Band_Parameter;1

---


## Child interfaces
* [Discharge_Air_Static_Pressure_Proportional_Band_Parameter](Discharge_Air_Static_Pressure_Proportional_Band_Parameter.md)
* [Exhaust_Air_Static_Pressure_Proportional_Band_Parameter](Exhaust_Air_Static_Pressure_Proportional_Band_Parameter.md)
* [Supply_Air_Static_Pressure_Proportional_Band_Parameter](Supply_Air_Static_Pressure_Proportional_Band_Parameter.md)

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
