[Point](../../../Point.md) > [Sensor](../../Sensor.md) > [Flow_Sensor](../Flow_Sensor.md) > [Air_Flow_Sensor](.)
# Air_Flow_Sensor

**Display name:** Air Flow Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Air_Flow_Sensor;1

---


## Child interfaces
* [Bypass_Air_Flow_Sensor](Bypass_Air_Flow_Sensor.md)
* [Fume_Hood_Air_Flow_Sensor](Fume_Hood_Air_Flow_Sensor.md)
* [Mixed_Air_Flow_Sensor](Mixed_Air_Flow_Sensor.md)
* [Outside_Air_Flow_Sensor](Outside_Air_Flow_Sensor.md)
* [Return_Air_Flow_Sensor](Return_Air_Flow_Sensor.md)
* [Discharge_Air_Flow_Sensor](Discharge_Air_Flow_Sensor/Discharge_Air_Flow_Sensor.md)
* [Exhaust_Air_Flow_Sensor](Exhaust_Air_Flow_Sensor/Exhaust_Air_Flow_Sensor.md)
* [Supply_Air_Flow_Sensor](Supply_Air_Flow_Sensor/Supply_Air_Flow_Sensor.md)

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
