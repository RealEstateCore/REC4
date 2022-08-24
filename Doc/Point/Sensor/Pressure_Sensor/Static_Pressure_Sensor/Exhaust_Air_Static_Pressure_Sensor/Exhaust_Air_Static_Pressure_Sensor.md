[Point](../../../../Point.md) > [Sensor](../../../Sensor.md) > [Pressure_Sensor](../../Pressure_Sensor.md) > [Static_Pressure_Sensor](../Static_Pressure_Sensor.md) > [Exhaust_Air_Static_Pressure_Sensor](#)
# Exhaust_Air_Static_Pressure_Sensor

**Display name:** Exhaust Air Static Pressure Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Exhaust_Air_Static_Pressure_Sensor;1

---


## Child interfaces
* [Average_Exhaust_Air_Static_Pressure_Sensor](Average_Exhaust_Air_Static_Pressure_Sensor.md)
* [Lowest_Exhaust_Air_Static_Pressure_Sensor](Lowest_Exhaust_Air_Static_Pressure_Sensor.md)

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
